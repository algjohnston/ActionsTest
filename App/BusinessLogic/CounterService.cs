using System;

namespace App.BusinessLogic;

public class CounterService
{
    private int count = 0;

    public (int count, string message) Increment()
    {
        count++;
        return (
            count,
            count == 1 
                ? $"Clicked {count} time"
                : $"Clicked {count} times"
        );
    }
}