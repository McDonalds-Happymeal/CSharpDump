using System;

public class reverseString
{
    public static void Main(string[]args)
    {
        string input = Console.ReadLine();
        char[] i = input.ToCharArray();

        for (int x = (i.Length)-1;x>=0;x--) {
            Console.Write(i[x]);
        }
    }
}