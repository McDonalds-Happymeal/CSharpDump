using System;

public class Euler
{
    public static void Main(string[]args)
    {
        int sum,i, total ,temp=0;
        int x =1;
        Console.WriteLine("Select :");
        int max = Convert.ToInt32(Console.ReadLine());

        while (x<max)
        {
            total=0;
            sum = 0;
            i = x;
            sum =0;
            while (i>0)
            {
                sum = sum + (i*i);
                total = total +i;
                i--;
            }
            Console.WriteLine("{1} - {0} = {2} diff {3}",sum,total*total,(total*total)-sum,(total*total)-sum-temp);
            temp = (total*total)-sum;
            x++;
        }
    }
}