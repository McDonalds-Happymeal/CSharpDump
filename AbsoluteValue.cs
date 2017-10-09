using System;
public class AbsoluteValue
{
    public static void Main(string[]args)
    {
        int x,y,z = 0;
        Console.WriteLine("This program will calculate absoulute value in multiple ways.");
        Console.Write("\ninsert vlaue to calculate");
        x = Convert.ToInt32(Console.ReadLine());

        if (x<0) {
            y = -x;
        }
        else {
            y=x;
        }
        Console.WriteLine("Absolute value way 1: {0}",y);

        z = x<0 ? -x : x;
        Console.WriteLine("Absolute value way 2: {0}",z);
    }
}