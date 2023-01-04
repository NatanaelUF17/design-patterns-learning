public class VehicleFactory
{
    public static IVehicle GetVehicle(string type)
    {
        IVehicle objectType = null;

        objectType = type.ToLower() switch
        {
            "car" => new Car(),
            "bike" => new Bike(),
            _ => objectType
        };

        return objectType;
    }
}