using System;

public class BasicProgram 
{
	public static void Main(string[]args) 
	{
		Console.Clear();
		Console.WriteLine("Welcome to CS with CS");
		Console.WriteLine("\t\t\t\t\"thats Computer science with C sharp\"");
		Console.WriteLine("\n\nTodays date is " + DateTime.Now );
		Console.Write("Lets start easy and add two number Together!\nPick your First number:");
		
		double num1 = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("\n\n and your Second number:");
		double num2 = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("And your total is:" + (num1+num2));
		
		Console.Write("\n\n\nPress Enter to continue");
		Console.ReadLine();
		
		
		Console.Clear();
		Console.WriteLine("Ok lets try hards lets divide two number\nEnter Both Below");
		num1 = Convert.ToDouble(Console.ReadLine());
		num2 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("\n\n" + num1 + " divided by " + num2 + " eqauls " + (num1/num2) + " With a Reminder of " + (num1%num2));
		
		Console.WriteLine("But thats not quite Right becuase only 5 year olds use reminders so lets do that as a Double");
		double answer = num1/num2;
		Console.WriteLine(answer);
		
	}
}