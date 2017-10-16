using System;

public class fibonacci
{
    public static void Main(string[]args)
    {
        int x = 1;
        int y =0;
        int z = 0;
        Console.Write("{0}, ",y);
        for (int i =0; i<=20; i++)
        {
            z = x + y;
            y= x;
            x = z;
            Console.Write("{0}, ",y);
        }

    }
}