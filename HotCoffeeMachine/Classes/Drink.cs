using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCoffeeMachine.Classes
{
    public abstract class Drink : IDrink
    {
        public double PERCENT { get; } = 0.3;

        abstract public string name { get; }
        abstract public double price { get; }

        public IComponentAndPrice componentAndPrice { get; set; }
        

        public Drink(IComponentAndPrice componentAndPrice)
        {
            this.componentAndPrice= componentAndPrice;  
        }


    }
}
