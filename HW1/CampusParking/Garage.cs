namespace CampusParking;

public class Garage
{
    private readonly ParkingSpot[] spots;

    public string Name { get; }
    public int Capacity => spots.Length;

    public Garage(string name, int capacity)
    {
    }

    public int FreeSpotCount()
    {
        throw new NotImplementedException();
    }

    public ParkingSpot GetSpot(int number)
    {
        throw new NotImplementedException();
    }

    public ParkingSpot? FindSpotOf(string plate)
    {
        throw new NotImplementedException();
    }

    public Ticket? Enter(Vehicle vehicle, int minute)
    {
        throw new NotImplementedException();
    }

    public decimal Exit(Ticket ticket, int minute)
    {
        throw new NotImplementedException();
    }

    public string Describe()
    {
        throw new NotImplementedException();
    }
}