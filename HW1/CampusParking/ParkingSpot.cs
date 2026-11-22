namespace CampusParking;

public class ParkingSpot
{
    public int Number { get; }
    public Vehicle? Occupant { get; private set; }

    public ParkingSpot(int number)
    {
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "The spot number must be at least 1.");
        }

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