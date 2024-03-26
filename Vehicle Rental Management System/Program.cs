using System;
using System.Linq;
public class Vehicle
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    private decimal rentalPrice;

    //To get the rental price of each vehicle
    public decimal RentalPrice
    {
        get { return rentalPrice; }
        set { rentalPrice = value; }
    }

    //To get the model, manufacturer, model year, and rental price of the renting vehicle
    public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    //To display the details of the vehicle
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice}");
    }
}
