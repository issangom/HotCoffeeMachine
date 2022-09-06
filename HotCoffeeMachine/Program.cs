using HotCoffeeMachine.Classes;
using HotCoffeeMachine.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Transactions;

bool displayMenu = true;


while (displayMenu)
{
   
    var option = DisplayMenu();
    displayMenu = true;

    if (option == "1"|| option == "2" || option == "3" )
    {
        var serviceProvider = BuldServices.BuildServiceProvider(option);
        var drinkOrder = serviceProvider.GetService<DrinkOrder>();
        drinkOrder.process();
    }
    if (option == "99")
    {
        Abientot();
        displayMenu = false;
    }
  
    

}



static string DisplayMenu()
{
    Console.Clear();
    Console.WriteLine("Liste des boissons :");
    Console.WriteLine("1) Expresso");
    Console.WriteLine("2) Allongé");
    Console.WriteLine("3) Capuccino");
    //Console.WriteLine("4) Chocolat");
    //Console.WriteLine("5) The");
    Console.WriteLine("99) Exit");
    Console.Write("\r\nSelectionnez une boisson chaude: ");
    return Console.ReadLine();
}

static void Abientot()
{
    Console.Clear();
    Console.WriteLine($"MERCI AU REVOIR");
    Console.ReadKey();
}



