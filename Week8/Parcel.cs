namespace Week8;

public class Parcel : DeliveryItem
{
    private string Dimensions;
    
    public Parcel(string trackingNumber, double weight, string dimensions) : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
    }
    
    public override double CalculateCost()
    {
        double price = 50 + (Weight * 25);
        return price;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimensions}");
    }
}