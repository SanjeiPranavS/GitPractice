using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingStatement.Model
{
    public class BlogPostDataModel : Observable.ObservableObject
    {
        private PersonDataModel _person;
        private DateTime _dateOfCreation;
        private string _blogTopic;
        private string _blogContent;
        private int _upVoteCount;
        private int _downVoteCount;

        public PersonDataModel Person
        {
            get => _person;
            set => SetField(ref _person, value);
        }

        public DateTime DateOfCreation
        {
            get => _dateOfCreation;
            set => SetField(ref _dateOfCreation, value);
        }

        public string BlogTopic
        {
            get => _blogTopic;
            set => SetField(ref _blogTopic, value);
        }

        public string BlogContent
        {
            get => _blogContent;
            set => SetField(ref _blogContent, value);
        }

        public int UpVoteCount
        {
            get => _upVoteCount;
            set => SetField(ref _upVoteCount, value);
        }

        public int DownVoteCount
        {
            get => _downVoteCount;
            set => SetField(ref _downVoteCount, value);
        }
    }

   
    
}
