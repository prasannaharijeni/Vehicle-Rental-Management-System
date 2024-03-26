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
//Car class was created to inherit all the details from the user
public class Car : Vehicle
{
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType, string transmission, bool convertible) : base(model, manufacturer, year, rentalPrice)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");
    }
}

//creating the truck class to inherit all the details from the vehicle class
public class Truck : Vehicle
{
    public double Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    public Truck(string model, string manufacturer, int year, decimal rentalPrice, double capacity, string truckType, bool fourWheelDrive) : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"\nCapacity: {Capacity} tons, Truck Type: {TruckType}, Four-Wheel Drive: {FourWheelDrive}");
    }
}

//Creating the Motorcycle class to inherit all the information from the vehicle class
public class Motorcycle : Vehicle
{
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing) : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}cc, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
    }
}