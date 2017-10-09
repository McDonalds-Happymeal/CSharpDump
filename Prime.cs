using System;

public class Prime
{
    public static void Main(string[]args)
    {
        //Sieve of Eratosthenes
        bool isPrime=false;
        int x = 0;
        int total =0;
        int i = 1;

        Console.WriteLine("this Program is designed to calculate primes; this is not the best or correct way to do this and at the moment just brute forces calculation");

        Console.Write("\n\nWould you like to check a number or list primes (\"check\" or \"list\") : ");
        string type = Console.ReadLine();

        switch (type) {

            case "list"://----------------------------------LIST------
                Console.Write("\n\nPlease input a Integer that will be the higest number whis program will search to:");
        int max = Convert.ToInt32(Console.ReadLine());

        for (i = 1;i<max;i++)
        {
                isPrime=true;
                x = i;
                while (x!=1 && isPrime)
                {
                    if (i%x==0&&x!=1&&i!=x){
                        isPrime=false;
                        //Console.WriteLine("{0} % {1} = {2}",i,x,i%x);
                    }
                    x--;
                }
                if(isPrime){
                    total++;
                    Console.Write("{0},",i);
                }
        }
        Console.WriteLine("\n\nI got a total of {0} Primes in {1}",total,"WIP");
            break;//------------------------------------------

            case "check" :

                Console.Write("\nEnter Value to check:");
                isPrime=true;

                i=Convert.ToInt32(Console.ReadLine());
                x=i;
                 while (x!=1 && isPrime)
                {
                    if (i%x==0&&x!=1&&i!=x){
                        isPrime=false;
                        //Console.WriteLine("{0} % {1} = {2}",i,x,i%x);
                    }
                    x--;
                }

                if(isPrime){
                    Console.Write("{0} is a Prime.",i);
                }
                else {
                    Console.Write("{0} is a is NOT Prime.",i);
                }

            break;

            default:
                Console.WriteLine("WRONG CODE");
            break;
        }
    }
}