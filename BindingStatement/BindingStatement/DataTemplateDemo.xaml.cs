using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BindingStatement.Model.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BindingStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DataTemplateDemo : Page,INotifyPropertyChanged
    {
        private string _currentTime;
        public  static CustomUserControlViewModel ViewModel { get; set; }
        

        public string CurrentTime
        {
            get => _currentTime;
            set
            {
                _currentTime = value; 
                OnPropertyChanged();
            }
        }

        public DataTemplateDemo()
        {
            this.InitializeComponent();
            
            ViewModel = new CustomUserControlViewModel();

            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += TimerOnTick;
            timer.Start();

        }

        private void TimerOnTick(object sender, object e)
        {
            //  TimeShowerTextBlock.Text = DateTime.Now.ToString("hh:mm:ss");
            CurrentTime = DateTime.Now.ToString("hh:mm:ss");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
    }


}
