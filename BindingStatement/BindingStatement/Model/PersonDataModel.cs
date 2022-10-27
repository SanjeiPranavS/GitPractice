using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingStatement.Model
{
    public class PersonDataModel : INotifyPropertyChanged
    {
        private string _rollNo;
        public string RollNo
        {
            get => _rollNo;
            set
            {
                _rollNo = value;
                OnPropertyChanged("RollNo");
                OnPropertyChanged("FullName");
            }

        }
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("FullName");
            }

        }

        private string _fullName;
        public string FullName
        {
            get => $"{Name} {RollNo}";
            set
            {
                _fullName = value;
                OnPropertyChanged("FullName");
            }

        }
        private string _department;
        public string Department
        {
            get => _department;
            set
            {
                _department = value;
                OnPropertyChanged("Department");
            }

        }

        private string _contactNumber;
        public string ContactNumber
        {
            get => _contactNumber;
            set
            {
                _contactNumber = value;
                OnPropertyChanged("ContactNumber");
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
