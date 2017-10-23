using System;

public class countWords
{
    public static void Main(string[]args)
    {
        Console.WriteLine("This program will take a input string and calculate how may words appear.");

        Console.Write("\ninput: ");
        string input = Console.ReadLine();
        int words =1;

        char[] i = input.ToCharArray();

        foreach (char val in i)
        {
            if(val==' '){
                words++;
            }
        }

        Console.WriteLine("The string has approximatly {0} words.",words);
    }
}