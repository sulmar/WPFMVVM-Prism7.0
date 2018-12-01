using Prism.ModuleA.IServices;
using Prism.ModuleA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.ModuleA.Services
{
    public class ProductsService : IProductsService
    {
        public IList<Product> Get()
        {
            throw new NotImplementedException();
        }
    }
}
