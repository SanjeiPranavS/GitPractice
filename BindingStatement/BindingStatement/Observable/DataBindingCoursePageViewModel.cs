using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace BindingStatement.Observable
{
    public class DataBindingCoursePageViewModel : ObservableObject
    {
        public string  CurrentTime => DateTime.Now.ToString("hh:mm:ss");
        private string _userName;
        private bool    _isNameFormNeed = true;
        public bool    IsSubmitButtonEnabled => UserName?.Trim().Length >= 3;

        public bool IsNameFormNeed
        {
            get => _isNameFormNeed;
            set => SetField(ref _isNameFormNeed, value);
        }
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(IsSubmitButtonEnabled));
            }
        }

        public DataBindingCoursePageViewModel()
        {
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += ((sender, o) => OnPropertyChanged(nameof(CurrentTime)));
            timer.Start();
        }
        
        public Visibility GetUserWelcomeTextBoxVisibility()
        {
            return IsNameFormNeed ? Visibility.Collapsed : Visibility.Visible;
        }
        public void Submit()
        {
            if (!string.IsNullOrEmpty(UserName) && IsNameFormNeed)
            {
                //var dlg = new Windows.UI.Popups.MessageDialog($"Hello {UserName}!");
                //dlg.ShowAsync();
                IsNameFormNeed = false;
                OnPropertyChanged(nameof(GetUserWelcomeTextBoxVisibility));
            }
        }

    }

    
}
