using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_Sklepowa
{
    public class CashMachine
    {
        public List<ProductList> productList = new();

        public void AddList()
        {
            productList.Add(new ProductList
            {
                BarCode = "001",
                ProductName = "Masło",
                Price = 6.5M
            });
            productList.Add(new ProductList
            {
                BarCode = "002",
                ProductName = "Chleb Wiejski",
                Price = 4.5M
            });
            productList.Add(new ProductList
            {
                BarCode = "003",
                ProductName = "Makaron Babuni",
                Price = 9.2M
            });
            productList.Add(new ProductList
            {
                BarCode = "004",
                ProductName = "Dżem truskawkowy",
                Price = 8.1M
            });
            productList.Add(new ProductList
            {
                BarCode = "005",
                ProductName = "Kiełbasa myśliwska",
                Price = 29.0M
            });
            productList.Add(new ProductList
            {
                BarCode = "006",
                ProductName = "Szynka konserwowa",
                Price = 22.0M
            });
            productList.Add(new ProductList
            {
                BarCode = "007",
                ProductName = "Chipsy paprykowe",
                Price = 6.0M
            });
            productList.Add(new ProductList
            {
                BarCode = "008",
                ProductName = "Serek Wiejski",
                Price = 3.5M
            });
            productList.Add(new ProductList
            {
                BarCode = "009",
                ProductName = "Sól kuchenna",
                Price = 2.7M
            });
            productList.Add(new ProductList
            {
                BarCode = "010",
                ProductName = "Cukier Kryształ",
                Price = 3.2M
            });
        }
        public void ViewProductList()
        {
            Console.WriteLine("Kod Kreskowy | Nazwa produktu | Cena Produktu");
            foreach (var item in productList)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"{item.BarCode:C} | {item.ProductName:C} | {item.Price:C}");

            }
        }


    }
}
