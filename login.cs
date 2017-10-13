using System;

public class login
{
    public static void Main(string[]args)
    {
        int username = 10;
        int password = 4567;
        int passInput, userInput;
        do
        {
            Console.Write("Input UserName:");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input PassWord:");
            passInput = Convert.ToInt32(Console.ReadLine());
        }
        while (!(userInput==username && passInput == password));

    }
}