using System;

public class timesTables
{
    public static void Main(string[]args)
    {
        int i = 2;
        int x = 0;
        while (i<=12)
        {
            x=1;
            while (x<=12)
            {
                Console.Write("{0} ",i*x);
                x++;
            }
            Console.Write("\n");
            i++;
        }
    }
}