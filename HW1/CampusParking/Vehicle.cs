namespace CampusParking;

public class Vehicle
{
    public string Plate { get; }
    public string Owner { get; }

    public Vehicle(string plate, string owner)
    {
        Plate = plate;
        Owner = owner;
    }

    public static string NormalizePlate(string plate)
    {
        throw new NotImplementedException();
    }

    public string Describe()
    {
        return $"{Plate} - {Owner}";
    }
}