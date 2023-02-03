using Kasa_Sklepowa;
//Powołanie do życia listy produktów
var cashMachine = new CashMachine();
var message = new Message();
var shoppingCart = new ShoppingCart();
//Dodawanie elementó do listy produktów
cashMachine.AddList();

message.DisplayWelcomeScreen();
//główna logika programu:
while (true)
{
    message.MenuCashRegisterScreen();
    if (!int.TryParse(Console.ReadLine(), out int menulist) || menulist < 1 || menulist > 3)
    {
        Console.Clear();
        message.MenuError();
    }
    else
    {
        switch (menulist)
        {
            case 1://wyświetla liste produktów
                Console.Clear();
                cashMachine.ViewProductList();
                break;
            case 2://wyświetla liste zkaupów
                Console.Clear();
                shoppingCart.StartShoping();
                return;
            case 3://zakończa program
                Console.Clear();
                message.MenuCashexit();
                return;
            default:
                Console.WriteLine("Nieznana Opcja");
                break;

        }
    }
}