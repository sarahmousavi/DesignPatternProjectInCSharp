using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Subsystem
    public class ProductCatalog
    {
        public void GetProducts()
        {
            Console.WriteLine("Fetching Products from the catalog...");
        }
    }
}