using System;
public class Negetives
{
    public static void Main(string[]args)
    {
        Console.WriteLine("This program will take 2 number and will tell you if two numbers are negetive and weather they are odd or even. Inputs must be integers.");
        Console.Write("\nInput x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nInput y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x<0&&y<0) {
            Console.WriteLine("BOTH inputs are negetive.");
        }
        else {
            Console.WriteLine("One or more inputs was posotive.");
        }

        if(x%2==0) {
            Console.WriteLine("x is EVEN.");
        }
        else {
             Console.WriteLine("x is ODD.");
        }

         if(y%2==0) {
            Console.WriteLine("y is EVEN.");
        }
        else {
             Console.WriteLine("y is ODD.");
        }
    }
}