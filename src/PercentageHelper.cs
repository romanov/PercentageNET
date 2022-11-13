namespace PercentageNET;

using System;

using JetBrains.Annotations;
using PercentageNET.SharedInternal;

public static class PercentageHelper
{
    [Pure]
    [PublicAPI]
    public static decimal Count(
        decimal inputNumber,
        decimal percentageAmount)
    {
        
        PercentageNetGuards.ThrowIfNull(inputNumber, nameof(inputNumber));
        PercentageNetGuards.ThrowIfNull(percentageAmount, nameof(percentageAmount));
        
        var number = Math.Abs(inputNumber);
        var percentage = Math.Abs(percentageAmount);
        var amount = number * (percentage / 100);

        return amount;
    }

       
    [Pure]
    [PublicAPI]
    public static decimal Subtract(
        decimal inputNumber,
        decimal percentageAmount)
    {
        
        PercentageNetGuards.ThrowIfNull(inputNumber, nameof(inputNumber));
        PercentageNetGuards.ThrowIfNull(percentageAmount, nameof(percentageAmount));
        
        
        var number = Math.Abs(inputNumber);

        return number - Count(inputNumber, percentageAmount);
    }

    
    [Pure]
    [PublicAPI]
    public static decimal Add(
        decimal inputNumber,
        decimal percentageAmount,
        AddMode mode = AddMode.Simple)
    {
        
        PercentageNetGuards.ThrowIfNull(inputNumber, nameof(inputNumber));
        PercentageNetGuards.ThrowIfNull(percentageAmount, nameof(percentageAmount));
        
        
        var number = Math.Abs(inputNumber);

        if (mode == AddMode.Simple)
        {
            return number + Count(inputNumber, percentageAmount);
        }

        // up-charge the input amount by percentage
        // for example: you want to add "real" 20% to 1000 = 1250
        // 1250 - 20% = 1000
        var upchargeAmount = number / (1 - (percentageAmount / 100));

        return upchargeAmount;
    }
    
    [Pure]
    [PublicAPI]
    public static decimal Compare(
        decimal compareTo,
        decimal secondNumber)
    {
       PercentageNetGuards.ThrowIfNull(compareTo, nameof(compareTo));
       PercentageNetGuards.ThrowIfNull(secondNumber, nameof(secondNumber));

        var amount = (compareTo - secondNumber) / Math.Abs(compareTo) * 100;

        return amount;
    }

    
    
}
