
namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodProduct food1 = new FoodProduct("Kartof", 80, "Terevez", "04/03/2024");
            Inventory invertory = new Inventory();
            invertory.AddProduct(food1);
            invertory.List();
            string sname = Console.ReadLine();
            invertory.Search(sname,Inventory.products);
        }
    }
}
