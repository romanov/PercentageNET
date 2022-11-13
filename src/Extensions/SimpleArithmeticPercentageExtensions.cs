// ReSharper disable once CheckNamespace
namespace PercentageNET;

using JetBrains.Annotations;


public static class SimpleArithmeticPercentageExtensions
{
    [Pure]
    [PublicAPI]
    public static decimal CountPercent(
        this decimal inputNumber,
        decimal percentageAmount)
    {
        return PercentageHelper.Count(inputNumber, percentageAmount);
    }

    [Pure]
    [PublicAPI]
    public static decimal SubtractPercent(
        this decimal inputNumber,
        decimal percentageAmount)
    {
        return PercentageHelper.Subtract(inputNumber, percentageAmount);
    }

    [Pure]
    [PublicAPI]
    public static decimal AddPercent(
        this decimal inputNumber,
        decimal percentageAmount,
        AddMode mode = AddMode.Simple)
    {
        return PercentageHelper.Add(inputNumber, percentageAmount, mode);
    }
}