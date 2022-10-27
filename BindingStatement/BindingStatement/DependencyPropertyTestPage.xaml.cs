using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BindingStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DependencyPropertyTestPage : Page, INotifyPropertyChanged
    {
        public int TestNumber
        {
            get => _testNumber;
            set
            {
                if (value == _testNumber) return;
                _testNumber = value;
                OnPropertyChanged();
            }
        }

        public string CurrentDateTime
        {
            get => _currentDateTime;
            set
            {
                if (value == _currentDateTime) return;
                _currentDateTime = value;
                OnPropertyChanged();
            }
        }

        public DependencyPropertyTestPage()
        {
            this.InitializeComponent();
           // DataContext = this;
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            int num = 0;
            timer.Tick += delegate
            {
                // num = 0;
                if (Counter == Int32.MaxValue)
                {
                    num = 0;
                }
                else
                {
                    num = Counter + 1;
                }

                Counter = num;

            };
            timer.Tick += (sender, o) =>
            {

                CurrentDateTime = DateTime.Now.ToString("hh:mm:ss");
            };
            timer.Start();

        }



        public int Counter
        {
            get => (int)GetValue(CounterDependencyProperty);
            set => SetValue(CounterDependencyProperty, value);
        }  
        public static readonly DependencyProperty CounterDependencyProperty = DependencyProperty.Register(nameof(Counter),
                                                                                                    typeof(int),
                                                                                typeof(DependencyPropertyTestPage),
                                                                                        new PropertyMetadata(1));



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int _counter = 1;
        private int _testNumber;
        private string _currentDateTime;

        //public int Counter
        //{
        //    get { return _counter; }
        //    set
        //    {
        //        _counter = value;
        //        OnPropertyChanged();
        //    }
        //}



        /*
         * we are reading certain property of an Control in a page it mush travese through each and every object until it reaches that
         * respective objects property
         * instead we can simply read the key i.e in static depencyobject collection and get the value
         * Dependency obejct also has property change notification feature which will invoke the chain of subscribers
         * while writting the values to those properties ,runtime will go through the heirearchy and set the value in collection adn also in respective clr property
         *When we create a custom control inheriting from dependency and maintaining this collection is going to be a vital part
         * We should use INotifyPropertyChange instead of Dependency property if the source change happens in clr objects
         */
        /*
         * Class Emp :DependencyProperty
         * {
         * \\ by inheriting DependencyProperty we are asking the runtime to have the respective class property in static collection but emp class is not
         * a kind of controller class ,reading and writing can be done directly into the employee class ,but by innheriting we are maintaing data as replica in
         * dependency object collection,ultimately it is going to be a burden in memory
         * There will be a larger foot print if we use dependency object for our data source classes
         *
         * }
         */





    }

    
}
