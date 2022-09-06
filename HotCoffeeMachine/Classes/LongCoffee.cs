using HotCoffeeMachine.Classes;

public class LongCoffee : Drink
{

    public LongCoffee(IComponentAndPrice componentAndPrice) : base(componentAndPrice)
    {
    }

    public override string name
    {
        get { return "Allongé"; }
    }


    public override double price
    {
        get {
            return ((base.componentAndPrice.CoffeePrice * 1) + (base.componentAndPrice.waterPrice * 2))
        + ((base.componentAndPrice.CoffeePrice * 1) + (base.componentAndPrice.waterPrice * 2)) * PERCENT;
        }
        
    }

}