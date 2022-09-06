using HotCoffeeMachine.Classes;

public class Capuccino : Drink
{


    public Capuccino(IComponentAndPrice componentAndPrice) : base(componentAndPrice)
    {
    }

    public override string name
    {
        get { return "Capuccino"; }
    }


    public override double price
    {
        get
        {
            return ((componentAndPrice.CoffeePrice * 1) + (componentAndPrice.waterPrice * 1)+ (componentAndPrice.ChocolatePrice * 1)+ (componentAndPrice.CreamPrice * 1))
        + ((componentAndPrice.CoffeePrice * 1) + (componentAndPrice.waterPrice * 1) + (componentAndPrice.ChocolatePrice * 1) + (componentAndPrice.CreamPrice * 1)) * PERCENT;
        }
    }

}