using System.Threading.Tasks;
using System.Threading;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
        
using BindingStatement.ExtensionMethods;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BindingStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AsyncTestPage : Page
    {
        public AsyncTestPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.Name  =    "UI thread";
            (Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId + " at main method").Debug();
            var dummy  =  MakeTeaAsync();
            dummy.Wait();
            (Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId + " at main method").Debug();
        }
        private static async Task<string> MakeTeaAsync()
        {
            (Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId + " at MakeTeaAsync before calling Boiling water").Debug();
            var water = BoilWaterAsync();
            (Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId + " at MakeTeaAsync after calling Boiling water").Debug();
            "taking Cups out".Debug();
            "putting tea in cups".Debug();
            var tea = $"poring {await water} in the tea cup";
            (Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId + " at MakeTeaAsync after awaiting  Boiling water").Debug();
            return tea;
        }
        private static async Task<string> BoilWaterAsync()
        {
            (Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId + " at  BoilWaterAsync before calling Task.delay").Debug();
            "Taking Kettle out".Debug();
            "Boiling water started".Debug();
            await Task.Delay(3000).ConfigureAwait(true);
            (Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId + " at  BoilWaterAsync after calling Task.delay").Debug();
            "boiling Water finished".Debug();
            return "hot water";

        }

        private static string MakeTea()
        {
            var water = BoilWater();
            "taking Cups out".Debug();
            "putting tea in cups".Debug();
            var tea = $"poring {water} in the tea cup";
            return tea;
        }

        private static string BoilWater()
        {
            "Taking Kettle out".Debug();
            "Boiling water started".Debug();
            Thread.Sleep(3000);
            "boiling Water finished".Debug();
            return "hot water";

        }

    }
}
