namespace ConsoleApp5
{

    public abstract class Vehicle
    {
        protected string Brand;
        protected string Model;
        protected int Year;

        protected Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}