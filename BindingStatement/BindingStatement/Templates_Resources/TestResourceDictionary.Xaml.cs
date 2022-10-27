using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Windows.UI.Xaml;
using BindingStatement.Model;

namespace BindingStatement.Templates_Resources
{
    public sealed partial class TestResourceDictionary : ResourceDictionary
    {
        public BlogPostDataModel BlogPost { get; set; }
        public TestResourceDictionary()
        {
            this.InitializeComponent();
            this.Bindings.Update();
        }
    }
}
