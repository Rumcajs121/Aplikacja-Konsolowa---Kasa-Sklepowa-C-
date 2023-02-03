using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_Sklepowa
{
    public class Message
    {
        public void DisplayWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witam w Sklepie \"MAŁGOSIA\" ");
            Console.ResetColor();
        }
        public void MenuCashRegisterScreen()
        {
            Console.WriteLine("");
            Console.WriteLine("1 ===> Lista Wszystkich Produktów ");
            Console.WriteLine("2 ===> Zakupy/Koszyk");
            Console.WriteLine("3 ===> Zakończ program");
            Console.WriteLine("");
            Console.WriteLine("Wybierz 1,2 lub 3: ");
        }
        public void MenuCashexit()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dziękujemy za zakupy");
            Console.ResetColor();
        }
        public void MenuError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podałeś złą wartość, podaj liczbę 1, 2 lub 3");
            Console.ResetColor();
        }
        public void ProductAdd()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Podaj kod kreskowy produktu, który chcesz dodać do koszyka lub wpisz P, aby zakończyć zakupy:");
            Console.ResetColor();
        }
    }
}
