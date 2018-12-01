using Prism.Hello.IServices;
using Prism.Hello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Hello.Services
{
    public class CustomersService : ICustomersService
    {
        public IList<Customer> Get()
        {
            throw new NotImplementedException();
        }
    }
}
