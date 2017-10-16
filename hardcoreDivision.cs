using System;

public class hardcoreDivsion
{
    public static void Main(string[]args)
    {
        Console.WriteLine("this Program will deivde this using hardcore maths(no mulit or division operators.");
        Console.Write("\nNumerator:");
        double x = Convert.ToDouble(Console.ReadLine());
        double store = x;
        Console.Write("\nDiviser");
        double y = Convert.ToDouble(Console.ReadLine());
        int answer = -1;
        do
        {
            x = x - y;
            answer++;
        }
        while (x>=0);
        x = x+y;

        Console.WriteLine("{0} / {1} = {2} r{3}",store,y,answer,x);
    }
}