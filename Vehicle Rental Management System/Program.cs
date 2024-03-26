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

//Creating the Rental Agency to perform the actions to rent a vehicle from the company
public class RentalAgency
{
    private Vehicle[] fleet = new Vehicle[50]; // Assuming a max of 50 vehicles for simplicity
    public decimal TotalRevenue { get; private set; }
    private int currentVehicleCount = 0;

    //To add a new vehicle to the rental company
    public void AddVehicle(Vehicle vehicle)
    {
        if (currentVehicleCount < fleet.Length)
        {
            fleet[currentVehicleCount] = vehicle;
            currentVehicleCount++;
            Console.WriteLine($"Vehicle {vehicle.Model} added to the fleet.");
        }
        else
        {
            Console.WriteLine("Fleet capacity reached. Cannot add more vehicles.");
        }
    }

    //To remove a vehicle from the rental company
    public bool RemoveVehicle(string model)
    {
        for (int i = 0; i < currentVehicleCount; i++)
        {
            if (fleet[i] != null && fleet[i].Model == model)
            {
                // Shift all vehicles down one slot from the point of removal
                for (int j = i; j < currentVehicleCount - 1; j++)
                {
                    fleet[j] = fleet[j + 1];
                }
                fleet[currentVehicleCount - 1] = null; // Clear the last entry
                currentVehicleCount--;
                Console.WriteLine($"Vehicle {model} removed from the fleet.");
                return true;
            }
        }
        Console.WriteLine("Vehicle not found.");
        return false;
    }

    //To rent a vehicle from the rental company
    public void RentVehicle(string model, decimal rentalPrice)
    {
        for (int i = 0; i < currentVehicleCount; i++)
        {
            if (fleet[i] != null && fleet[i].Model == model)
            {
                TotalRevenue += rentalPrice;
                Console.WriteLine($"{model} has been rented for {rentalPrice}.");
                return;
            }
        }
        Console.WriteLine("Vehicle is not available in the fleet.");
    }

    //To display the overall fleet to the user to select the ride from the available vehicles
    public void DisplayFleet()
    {
        Console.WriteLine("Fleet Details:");
        for (int i = 0; i < currentVehicleCount; i++)
        {
            if (fleet[i] != null)
            {
                fleet[i].DisplayDetails();
            }
        }
    }
}