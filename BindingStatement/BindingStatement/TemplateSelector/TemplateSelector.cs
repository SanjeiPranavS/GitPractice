using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BindingStatement.TemplateSelector
{
    public class TemplateSelector : DataTemplateSelector
    {
        public DataTemplate TestTemplate { get; set; }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return TestTemplate;
        }
    }
}