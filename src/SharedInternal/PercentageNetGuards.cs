namespace PercentageNET.SharedInternal;

using JetBrains.Annotations;

internal static class PercentageNetGuards
{
    
    public static void ThrowIfNull(
        decimal? input,
        string parameterName,
        string message = "The input value cannot be null or zero.")
    {
        switch (input)
        {
            case null:
                throw new ArgumentNullException(message, parameterName);
            case 0:
                throw new ArgumentException(message, parameterName);
        }
    }
    

    public static void ThrowIfNullOrZero(
        decimal? input,
        string parameterName,
        string message = "The input value cannot be null or zero.")
    {
        switch (input)
        {
            case null:
                throw new ArgumentNullException(message, parameterName);
            case 0:
                throw new ArgumentException(message, parameterName);
        }
    }
}