namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public double GetTotalCost()
    {
        double totalcost = 0;
        foreach (T item in _items)
        {
            totalcost += item.CalculateCost();
        }

        return totalcost;
    }
}