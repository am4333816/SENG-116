namespace CampusParking;

public static class Tariff
{
    public const int FreeMinutes = 30;
    public const int UnitMinutes = 30;
    public const decimal UnitRate = 8m;
    public const decimal MaxFee = 160m;

    public static decimal FeeFor(int minutes)
    {
        if (minutes < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(minutes), "The stay must not be negative.");
        }

        if (minutes <= FreeMinutes)
        {
            return 0m;
        }

        int units = (minutes + UnitMinutes - 1) / UnitMinutes;
        decimal fee = units * UnitRate;

        if (fee > MaxFee)
        {
            return MaxFee;
        }

        return fee;
    }
}