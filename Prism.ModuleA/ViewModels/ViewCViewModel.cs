using Prism.ModuleA.IServices;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.ModuleA.ViewModels
{
    public class ViewCViewModel  : BindableBase
    {
        private readonly IProductsService productsService;

        public ViewCViewModel(IProductsService productsService)
        {
            this.productsService = productsService;
        }
    }
}
