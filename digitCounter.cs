using System;

public class digitCounter
{
    public static void Main(string[]args)
    {
        Console.WriteLine("This program will take a interger input and calucate the number of digits");
        Console.Write("\nInput:");
        int input = Convert.ToInt32(Console.ReadLine());

        Math.Abs(input);

        int digits = 0;

        while(input >0)
        {
            digits++;
            input = input/10;
        }

        Console.WriteLine("The input has {0} total digits",digits);
    }
}