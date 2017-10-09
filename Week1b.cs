using System;

public class Week1b 
{
	public static void Main (string[]args)
	{
		Console.Write("\n\nWhat is your name: ");
		string name = Console.ReadLine();
		Console.Write("\nWhat is your age: ");
		int age = Convert.ToInt32(Console.ReadLine());
		Console.Clear();
		
		Console.WriteLine("Hello " + name + ".\nYou are approximatly " + age*365.25 + " days old.");
		
		Console.Write("\n\nInput 2 numbers to swap: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Input 1 = " + num1 + "\nInput 2 = " + num2);
		Console.WriteLine("now for some magic!");
		
		num1 = num1+num2;
		num2 = num1-num2;
		num1 = num1-num2;
		
		Console.WriteLine("Input 1 = " + num1 + "\nInput 2 = " + num2);
	}
}