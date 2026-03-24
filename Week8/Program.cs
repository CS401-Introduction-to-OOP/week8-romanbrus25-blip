namespace Week8;

class Program
{
    static void Main(string[] args)
    {
        Letter letter1 = new Letter("1", 1);
        Letter letter2 = new Letter("2", 0.5);
        Parcel parcel1 = new Parcel("3", 15, "20*25*20");
        Parcel parcel2 = new Parcel("4", 25, "20*25*30");
        
        letter1.PrintInfo();
        parcel2.PrintInfo();
        
        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        
        Console.WriteLine(myCargo.GetTotalCost());
    }
}