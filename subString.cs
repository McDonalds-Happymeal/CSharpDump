using System;

public class subString
{
    public static void Main(string[]args)
    {
        Console.WriteLine("This program will search for sub strings in a string.");

        Console.Write("\nstring: ");
        char[] input = Console.ReadLine().ToCharArray();
        Console.Write("\nSub Stringt: ");
        char[] subString = Console.ReadLine().ToCharArray();
        int sSPos = 0;
        int found = 0;
        foreach (char val in input)
        {
            if (val==subString[sSPos])
            {
                sSPos++;
            }
            else
            {
                sSPos = 0;
            }

            if(sSPos == subString.Length )
            {
                sSPos = 0;
                found++;
            }
        }

        if (found==0)
        {
            Console.WriteLine("sub string not found.");
        }
        else{
            Console.WriteLine("sub string found and occurs {0} times.", found);
        }
    }
}