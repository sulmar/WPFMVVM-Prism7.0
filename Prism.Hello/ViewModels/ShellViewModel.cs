using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prism.Hello.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly IRegionManager regionManager;

        public ICommand NavigateCommand { get; set; }

        public ShellViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);


        }

        private void Navigate(string uri)
        {
            regionManager.RequestNavigate("ContentRegion", uri);
        }
    }
}
