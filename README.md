**Vehicle Rental Management System**

Objective: The objective of this assignment is to design and implement a Vehicle Rental
Management System using object-oriented principles. You will practice inheritance,
abstraction, and encapsulation while developing classes to represent vehicles and a
rental agency.

**Application Details:**
1. Vehicle Class (Vehicle.cs):

•Create a class named Vehicle to represent a generic vehicle available for
rental.

• Include properties such as Model, Manufacturer, Year, and RentalPrice.

• Implement methods to get and set the vehicle's properties.

• Implement a method named DisplayDetails() to display the vehicle's
details.
2. Car Class (Car.cs):

• Create a class named Car that inherits from the Vehicle class.

• Add additional properties specific to cars, such as Seats, EngineType,
Transmission, and Convertible.

• Override the DisplayDetails() method to display the car's details, including
both common vehicle properties and car-specific properties.

3. Truck Class (Truck.cs):

• Create a class named Truck that inherits from the Vehicle class.

• Add additional properties specific to trucks, such as Capacity, TruckType,
and FourWheelDrive.

• Override the DisplayDetails() method to display the truck's details,
including both common vehicle properties and truck-specific properties.

4. Motorcycle Class (Motorcycle.cs):

• Create a class named Motorcycle that inherits from the Vehicle class.

• Add additional properties specific to motorcycles, such as EngineCapacity,
FuelType, and HasFairing.

• Override the DisplayDetails() method to display the motorcycle's details,
including both common vehicle properties and motorcycle-specific
properties.

5. RentalAgency Class (RentalAgency.cs):

• Create a class named RentalAgency to manage the rental agency's fleet of
vehicles.

• Include an array (Fleet) to store instances of vehicles.

• Include a property named TotalRevenue to track the total revenue earned
by the rental agency.

• Implement methods to add vehicles to the fleet, remove vehicles from the
fleet, and rent vehicles.

• Ensure proper encapsulation of class properties and methods.

**Guidelines:**

1. Inheritance:

• Utilize inheritance to create a hierarchy of classes where Car, Truck, and
Motorcycle inherit common properties and methods from the Vehicle class.

• Ensure that subclasses inherit properties and methods that are common to
all vehicles while being able to extend functionality with specific properties
and methods.

2. Abstraction:

• Use abstraction by defining a method DisplayDetails() in the Vehicle class
and override it in subclasses (Car, Truck, Motorcycle) to display specific
details unique to each vehicle type while maintaining the same method
signature.

• Encapsulate class properties and methods appropriately to hide internal
implementation details and expose only necessary functionality.

3. Encapsulation:

• Implement proper encapsulation by making class properties private and
providing public methods to access and modify them.

• Ensure that class methods perform necessary validations and operations to
maintain the integrity of the data.
Submission Instructions:

• Create separate C# files for each class (Vehicle.cs, Car.cs, Truck.cs, Motorcycle.cs,
RentalAgency.cs).

• Implement the classes and methods according to the provided specifications.

• Demonstrate the functionality of the classes in the Main method of a separate file
(Program.cs).
