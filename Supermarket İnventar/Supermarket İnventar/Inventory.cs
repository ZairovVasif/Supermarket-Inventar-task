
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Channels;
    using System.Threading.Tasks;

namespace Task
{
    internal class Inventory
    {
        public static List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);

        }
        public void List()
        {
            foreach (var item in products)
            {
                Console.WriteLine("Ad:" + item.Name + "\nQiymeti: " + item.Price + " \nCateqori:" + item.Category);
            }
        }
        public void Search(string search_name, List<Product> list)
        {
            foreach (var item in list)
            {
                if (search_name == item.Name)
                {
                    Console.WriteLine("Ad:" + item.Name + "\nqiymeti:" + item.Price + "\nCateqori:" + item.Category);
                }
            }


        }
}   }
          
     





