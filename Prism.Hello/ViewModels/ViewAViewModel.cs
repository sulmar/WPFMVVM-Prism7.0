using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prism.Hello.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }


        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }


        private DateTime? _lastUpdated;

        public DateTime? LastUpdated
        {
            get { return _lastUpdated; }
            set { SetProperty(ref _lastUpdated, value); }
        }


        public ICommand UpdateCommand { get; set;  }

        public ViewAViewModel()
        {
            UpdateCommand = new DelegateCommand(Update, CanUpdate)
                .ObservesProperty(() => FirstName)
                .ObservesProperty(() => LastName);
        }

       
        private void Update()
        {
            LastUpdated = DateTime.Now;
        }

        private bool CanUpdate()
        {
            return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
        }
    }
}
