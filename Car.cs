public class Car
{
    private string brand;
    private int year;
    private float price;

    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {brand}, Year: {year}, Price: Rs {price}");
    }
}
