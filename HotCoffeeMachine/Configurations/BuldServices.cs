using HotCoffeeMachine.Classes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCoffeeMachine.Configurations
{
    static class BuldServices
    {
        public static IServiceProvider BuildServiceProvider(string option)
        {
            IServiceCollection collection = new ServiceCollection();

            IConfiguration Configs = new ConfigurationBuilder()
                        .AddJsonFile("AppSettings.json", optional: false)
                        .Build();

            ComponentAnPrice cPrice = Configs.Get<ComponentAnPrice>();

            collection.AddSingleton<IComponentAndPrice>(cPrice);
            switch (option)
            {
                case "1":
                    collection.AddSingleton<IDrink, Espresso>();
                    break;
                case "2":
                    collection.AddSingleton<IDrink, LongCoffee>();
                    break;
                case "3":
                    collection.AddSingleton<IDrink, Capuccino>();
                    break;
                default:
                    //collection.AddSingleton<IDrink, Espresso>();
                    break;
            }
           


            collection.AddSingleton<IWriter, Writer>();
          
            collection.AddSingleton<DrinkOrder>();

            return collection.BuildServiceProvider();

        }
    }
}
