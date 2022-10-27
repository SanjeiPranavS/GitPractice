using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using BindingStatement.Model;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace BindingStatement.Templates_Resources
{
    
    public sealed partial class MyUserControl1 : UserControl
    {
        public BlogPostDataModel BlogPost => this.DataContext as BlogPostDataModel;
        public SolidColorBrush BlueBrush = new SolidColorBrush(Colors.Blue);
        public SolidColorBrush WhiteBrush = new SolidColorBrush(Colors.White);

        public MyUserControl1()
        {
            this.InitializeComponent();
            this.DataContextChanged +=  (s, e) => Bindings.Update();
        }

       
        private void MainGrid_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var Grid = sender as Grid;
            if (Grid.Background == BlueBrush)
            {
                Grid.Background = WhiteBrush;
            }
            else
            {
                Grid.Background = BlueBrush;
            }
        }

        private void UpvoteButton_OnClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var blogPostobj = button.DataContext as BlogPostDataModel;
                blogPostobj.UpVoteCount++;
            }

        }

        private void DownVoteButton_OnClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var blogPostobj = button.DataContext as BlogPostDataModel;
                blogPostobj.DownVoteCount--;
            }
        }
    }
}
