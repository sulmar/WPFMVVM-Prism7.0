using Prism.ModuleA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.ModuleA.IServices
{
    public interface IProductsService
    {
        IList<Product> Get();
    }
}
