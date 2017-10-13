using System;

public class whileLoop
{
    public static void Main(string[]args)
    {
        int i = 0;
        int x = 0;
        while (i<10) {
            x=1;
            while (x<=10) {
                Console.Write("{0} ",x);
                x++;
            }
            Console.Write("\n");
            i++;
        }
    }
}