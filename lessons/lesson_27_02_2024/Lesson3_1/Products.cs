/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product obj)
        {
            if (obj == null) 
                throw new ArgumentNullException("Wrong");
            if (this.Price >  obj.Price) return 1;
            if (this.Price < obj.Price) return -1;
            return 0;
        }
    }
}
*/