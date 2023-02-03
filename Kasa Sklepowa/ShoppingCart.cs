using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_Sklepowa
{
    public class ShoppingCart
    {

        public CashMachine cashMachine = new CashMachine();
        public List<ProductList> shoppingCartLists = new();
        public decimal totalPrice = 0;
        public decimal totalPriceVat = 0.23m;
        public void AddToCart(string barcode)
        {
            bool productFound = false;
            foreach (var item in cashMachine.productList)
            {
                if (item.BarCode == barcode)
                {
                    shoppingCartLists.Add(item);
                    totalPrice += item.Price;
                    productFound = true;
                    Console.WriteLine($"Dodano do koszyka:{item.ProductName}");
                    break;
                }
            }
            if (!productFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie ma produktu o takim kodzie kreskowym w naszym asortymencie");
                Console.ResetColor();
            }
        }
        public void DisplayCart()
        {
            Console.WriteLine("PARAGON");
            foreach (ProductList item in shoppingCartLists)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"{item.ProductName:C} | {item.Price:C}");
            }
            Console.WriteLine("-----------------");
            decimal totalPriceWithVat = totalPrice + (totalPrice * totalPriceVat);
            Console.WriteLine($"Cena do zapłaty: {totalPriceWithVat:C}");
            Console.WriteLine($"W tym Vat:{totalPrice * totalPriceVat:C}");
        }
        public void StartShoping()
        {
            cashMachine.AddList();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Podaj kod kreskowy produktu, który chcesz dodać do koszyka lub wpisz P, aby zakończyć zakupy:");
                Console.ResetColor();
                Console.WriteLine($"\nDo zapłaty:{totalPrice:C}");
                string idCode = Console.ReadLine();
                if (idCode == "p" || idCode == "P")
                {
                    Console.Clear();
                    break;
                }
                AddToCart(idCode);
            }
            DisplayCart();
        }
    }
}
