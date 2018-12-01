using Prism.Hello.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Hello.ViewModels
{
    public class ViewBViewModel : ViewModelBase
    {
        private readonly ICustomersService customersService;

        public ViewBViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;
        }
    }
}
