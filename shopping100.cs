using System;

public class shopping100
{
    public static void Main(string[]args)
    {
        Console.Write("how much is your giftcard worth:");
        double money =  Convert.ToDouble(Console.ReadLine());
        Console.Write("\nhow many items can you buy:");
        int items =  Convert.ToInt32(Console.ReadLine());

        while (items>0) {
            Console.WriteLine("You have £{0} left to spend and can choose {1} more item; how much is your next item:",money,items);

            money = money - Convert.ToDouble(Console.ReadLine());


            items--;
        }

        Console.WriteLine("i'm spent");
    }
}