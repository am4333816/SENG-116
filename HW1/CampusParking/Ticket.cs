namespace CampusParking;

public class Ticket
{
    public int Number { get; }
    public Vehicle Vehicle { get; }
    public ParkingSpot Spot { get; }
    public int EntryMinute { get; }
    public bool IsOpen { get; private set; }
    public decimal Fee { get; private set; }

    internal Ticket(int number, Vehicle vehicle, ParkingSpot spot, int entryMinute)
    {
        Number = number;
        Vehicle = vehicle;
        Spot = spot;
        EntryMinute = entryMinute;
    }

    internal void Close(decimal fee)
    {
        throw new NotImplementedException();
    }
}