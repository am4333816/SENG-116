namespace CampusParking;

public class Vehicle
{
    public readonly string Plate;
    public readonly string Owner;

    public Vehicle(string plate, string owner)
    {
        Plate = plate;
        Owner = owner;
    }

    public string Describe()
    {
        return $"{Plate} - {Owner}";
    }
}