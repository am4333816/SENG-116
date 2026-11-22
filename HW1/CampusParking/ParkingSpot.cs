namespace CampusParking;

public class ParkingSpot
{
    public readonly int Number;
    public Vehicle? Occupant;

    public ParkingSpot(int number)
    {
        Number = number;
    }

    public bool IsFree()
    {
        return Occupant == null;
    }

    public bool TryPark(Vehicle vehicle)
    {
        if (!IsFree())
        {
            return false;
        }

        Occupant = vehicle;
        return true;
    }

    public Vehicle? Leave()
    {
        Vehicle? leaving = Occupant;
        Occupant = null;
        return leaving;
    }

    public string Describe()
    {
        if (Occupant == null)
        {
            return $"#{Number} empty";
        }

        return $"#{Number} {Occupant.Plate}";
    }
}