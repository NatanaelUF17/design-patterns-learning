string input = string.Empty;

Console.Write("Enter a vehicle type: ");
input = Console.ReadLine();

// Here the Vehicle factory will get vehicle type object, based on the input.
IVehicle type = VehicleFactory.GetVehicle(input);

Console.WriteLine(type.GetType()); // Just to make sure we are getting the current type, checking it on runtime.
Console.WriteLine($"Type is {type.VehicleType()}");
Console.WriteLine($"Number of Wheel is {type.NumberOfWheels()}");