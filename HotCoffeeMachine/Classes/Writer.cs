public class Writer : IWriter
{
    public void Write(string name, double price)
    {
        var strPrice = string.Format(":{0:0.00}", price);
        Console.Write($"Le prix de vente de la boisson {name} est {strPrice} ");
        Console.Write("\r\n");
        Console.Write($"Tapez Entrer pour continuer ");
        Console.ReadKey();
    }

}