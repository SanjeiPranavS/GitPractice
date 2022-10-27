using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace BindingStatement.Templates_Resources
{
    public sealed partial class CustomClock : UserControl
    {

      
        public string CurrentTime
        {
            get { return (String)GetValue(CurrentTimeDependencyProperty); }
            set { SetValue(CurrentTimeDependencyProperty, value); }
        }
        public static readonly DependencyProperty CurrentTimeDependencyProperty  = DependencyProperty.Register(
            nameof(CurrentTime), typeof(string), typeof(CustomClock), new PropertyMetadata("NO value set"));

        public SolidColorBrush BackGround
        {
            get { return (SolidColorBrush)GetValue(BackGroundColorDependencyProperty); }
            set { SetValue(BackGroundColorDependencyProperty, value); }
        }

        public static readonly DependencyProperty BackGroundColorDependencyProperty = DependencyProperty.Register(
            nameof(BackGround), typeof(SolidColorBrush), typeof(CustomClock), new PropertyMetadata(default(SolidColorBrush)));



        public CustomClock()
        {
            this.InitializeComponent();
        }


    }
}
