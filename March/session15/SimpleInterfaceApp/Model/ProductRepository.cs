using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class ProductRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Product Records Created");
        }

        public void Delete()
        {
            Console.WriteLine("Product Records Deleted");

        }

        public void Read()
        {
            Console.WriteLine("Product Records Read");
        }

        public void Update()
        {
            Console.WriteLine("Product Records Updated");
        }
    }
}
