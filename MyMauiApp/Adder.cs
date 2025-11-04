using System;

namespace MyMauiApp;

public class Adder
{
    private int a;

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public void StoreAdd(int a, int b)
    {
        this.a = a + b;
    }

    public int GetStoredAdd()
    {
        return a;
    }
}
