using System;

public class pascalTraingle
{
    public static void Main(string[]args)
    {
        int x =0;
        for (int i =0;i<=8;i++)
        {
            Console.Write("\n");
            for (x=0;x<=i;x++)
            {
                Console.Write("{0}, ",x*i);
            }
        }
    }
}