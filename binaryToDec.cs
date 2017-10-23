using System;

public class binaryToDev
{
    public static void Main(string[]args)
    {
        char[] input = Console.ReadLine().ToCharArray();

        int total =0;
        int counter = 0;

         for (int x = (input.Length)-1;x>=0;x--) {


            if(input[x]=='1')
            {
                total = total +Convert.ToInt32(Math.Pow(2,counter));
            }

            counter++;
         }
         Console.WriteLine(total);
    }
}