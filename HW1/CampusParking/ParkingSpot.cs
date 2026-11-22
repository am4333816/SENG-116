namespace CampusParking;

public class ParkingSpot
{
    public readonly int Number;
    public Vehicle? Occupant;

    public ParkingSpot(int number)
    {
    }

    public bool IsFree()
    {
        throw new NotImplementedException();
    }

    public bool TryPark(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public Vehicle? Leave()
    {
        throw new NotImplementedException();
    }

    public string Describe()
    {
        throw new NotImplementedException();
    }
}