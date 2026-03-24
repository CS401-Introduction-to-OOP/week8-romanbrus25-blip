namespace Week8;

public abstract class DeliveryItem
{
    private string TrackingNumber;
    protected double Weight;

    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"TrackingNumber: {TrackingNumber} | Weight: {Weight}");
    }
}