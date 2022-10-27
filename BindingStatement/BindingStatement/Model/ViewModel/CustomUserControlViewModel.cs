using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Faker;


namespace BindingStatement.Model.ViewModel
{
  
    
    public class CustomUserControlViewModel
    {
        public ObservableCollection<BlogPostDataModel> BlogPosts { get; set; } 
            
        


        public CustomUserControlViewModel()
        {
          IEnumerable<BlogPostDataModel> blogs= GetBlogPost();
          BlogPosts = new ObservableCollection<BlogPostDataModel>(blogs);
        }
        private IEnumerable<BlogPostDataModel> GetBlogPost()
        {
           // var blogposts = new List<BlogPostDataModel>();
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {
                var blogpost = new BlogPostDataModel();

                blogpost.BlogContent =Faker.Lorem.Paragraph(5);
                blogpost.BlogTopic = Faker.Address.City();
                blogpost.DateOfCreation =Faker.Date.Birthday(8,55);
                blogpost.DownVoteCount = random.Next(10);
                blogpost.UpVoteCount = random.Next(10);
                    blogpost.Person = new PersonDataModel()
                    {
                        ContactNumber = "9894330917",
                        Name = Faker.Name.FullName(NameFormats.Standard),
                        Department = Faker.Company.Name(),
                        RollNo = Faker.Lorem.Words(5).ToString()
                    };
               
                yield return blogpost;
            }
        }
    }
}
