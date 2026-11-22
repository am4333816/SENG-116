namespace CampusParking;

public static class Tariff
{
    public const int FreeMinutes = 30;
    public const int UnitMinutes = 30;
    public const decimal UnitRate = 8m;
    public const decimal MaxFee = 160m;

    public static decimal FeeFor(int minutes)
    {
        throw new NotImplementedException();
    }
}