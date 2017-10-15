using System;

public class anagrams
{
    public static void Main(string[]args)
    {
        Console.WriteLine("This Program will accept to string and will tell you weather or not they are anagrams");

        Console.Write("\nString 1:");
        string string1 = Console.ReadLine();
        Console.Write("\nString 2:");
        string string2 = Console.ReadLine();
        
        char[] value1 = string1.ToCharArray();
        char[] value2 = string2.ToCharArray();

        Array.Sort(value1);
        Array.Sort(value2);

        bool isArray = true;
        if(value1.Length == value2.Length){
            int x =0;
            foreach(char i in value1)
            {
                if (!(i == value2[x]))
                {
                    isArray = false;
                }
                x++;
            }
        }
        else
        {
            isArray = false;
        }
        
    if (isArray) {
        Console.WriteLine("Values are anagrams of eachother.");
    }
    else
    {
        Console.WriteLine("value are not anagrams of eachother.");
    }

    }
}