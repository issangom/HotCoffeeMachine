using HotCoffeeMachine.Classes;

public class DrinkOrder 
{
    private readonly IDrink drink;   
    private readonly IWriter writer;
   //private readonly IComponentAndPrice componentAndPrice;

    public DrinkOrder(IDrink drink,  IWriter writer)
    {
        this.drink = drink;
        //this.componentAndPrice = componentAndPrice;
        this.writer = writer;
    }


    public string GetDrinkName() => this.drink.name;

    public double GetPrice()
    {
        return drink.price;
    }

    public void process()
    {

        writer.Write(GetDrinkName(), GetPrice());

    }


}