namespace DotPharma.Abstract;

public readonly struct Percentage
{
    private readonly double _percentage;

    public Percentage(double percentage)
    {
        if (percentage is not(>= 0 and <= 100))
            throw new ArgumentOutOfRangeException("Percentage value must be between 0 and 100.");

        _percentage = percentage;
    }

    public static double Of(Percentage percentage, double value) => value * (percentage / 100);
    public static Percentage Difference(double firstValue, double secondValue) => Math.Abs((firstValue - secondValue) / firstValue) * 100;

    public static implicit operator Percentage(double value) => new Percentage(value);

    public static implicit operator double(Percentage percentage) => percentage._percentage;


    public override string ToString()
    {
        return $"{_percentage:F2}%";
    }
}
