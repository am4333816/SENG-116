namespace CampusParking;

public class Vehicle
{
    public string Plate { get; }
    public string Owner { get; }

    public Vehicle(string plate, string owner)
    {
        if (string.IsNullOrWhiteSpace(plate))
        {
            throw new ArgumentException("The plate must not be empty.");
        }

        if (string.IsNullOrWhiteSpace(owner))
        {
            throw new ArgumentException("The owner must not be empty.");
        }

        Plate = NormalizePlate(plate);
        Owner = owner.Trim();
    }

    public static string NormalizePlate(string plate)
    {
        return plate.Trim().ToUpperInvariant().Replace(" ", "");
    }

    public string Describe()
    {
        return $"{Plate} - {Owner}";
    }
}