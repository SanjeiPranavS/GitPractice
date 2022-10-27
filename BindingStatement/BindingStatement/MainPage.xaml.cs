using BindingStatement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Extensions.DependencyInjection;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BindingStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly MainPageViewModel _viewModel;

        //==========================Custom DEPENDENCY Property==============================================
        /*
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
            "Label",
            typeof(string),
            typeof(MainPage),
            new PropertyMetadata(null)
        );


        public string Label    // CLR properties
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
        */
        public ExtensionMethods.CoverterTest ConverTest = new ExtensionMethods.CoverterTest();

        public PersonDataModel PersonDetail { get; set; } 
        public MainPage()
        {
            //Window.Current.f
            _viewModel = App.ServicePRovider.GetRequiredService<MainPageViewModel>();
            InitializeStudent();
            this.InitializeComponent();
         //   this.DataContext = PersonDetail;
        }

        private void InitializeStudent()
        {
            PersonDetail = new PersonDataModel
            {
                RollNo = "191Me215",
                Name = " supreme",
                Department = "Mechanical",
                ContactNumber = "9894330917"
            };
        }

        private void DataBindingCheckButton_Click(object sender, RoutedEventArgs e)
        {
           PersonDetail.RollNo = "some value";
           PersonDetail.Name = "some name";
           PersonDetail.ContactNumber = "9894330197";
           PersonDetail.Department = "some department";
        }
    }

    public class MainPageViewModel
    {
        private readonly IMessageWritter _messageWritter;

        public MainPageViewModel(IMessageWritter messageWritter)
        {
            _messageWritter = messageWritter;
        }
        public string Name { get; set; }
    }
}
/*
 *Target Property is always dependency property in data binding
 * binding acts as bridge between source and target
 *
 * Four type of Binding awailable
 *    OneWay
 *    TwoWay
 *   OneWayToSource
 *   One time
 * in case of two way binding we need to update the source that the target has changed and update yourself with the help of UpdateSourceTriggerProperty
 *in updateSoureTrigger porperty binding default is LostFocus
 *
 */
/*
 *
 * 1st normalization
 *   Each cell to be single valued
 * Entities in a Column are same type
 * Rows UniqueLy Identiifed  -Add unique Id ,or OR Add More coloums to make unique
 * (the order of the rows and the order of the coloums are irrelevent
 *
 *
 * 2 Nd Normalization
 * All Attributes(non - Key Colums) dependent on the key
 *
 * 3 rd Normalization
 * all Field can be determined only by the key int he table and no other colounm
 */