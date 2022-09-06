using HotCoffeeMachine.Classes;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Espresso : Drink 
{
    public Espresso(IComponentAndPrice componentAndPrice) : base(componentAndPrice)
    {
    }

    public override string name
    { 
        get { return "Espresso"; }
    }

    public override double price 
    {
        get
        {
            return ((componentAndPrice.CoffeePrice * 1) + (componentAndPrice.waterPrice * 1))
        + ((componentAndPrice.CoffeePrice * 1) + (componentAndPrice.waterPrice * 1)) * PERCENT;
        }
    }










}
