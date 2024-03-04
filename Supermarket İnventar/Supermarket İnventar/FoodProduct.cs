using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Product(string nm, decimal prc, string ctgry)
        {
            Name = nm;
            Price = prc;
            Category = ctgry;
        }

    }
    internal class FoodProduct : Product
    {
        public string ExpirationDate { get; set; }
        public FoodProduct(string nm, decimal prc, string ctgry, string exDate) : base(nm, prc, ctgry)
        {

            ExpirationDate = exDate;
        }



    }
    internal class NonFoodProduct
    {

    }


}