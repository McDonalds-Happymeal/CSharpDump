using System;

public class Welcome
{
	public static void Main(string[]args)
	{
		Console.WriteLine("Welcome to C#");
		Console.WriteLine("What is your name");
		string input = Console.ReadLine();
		Console.WriteLine("\nHello There " + input + ". Are you Ready to see how deep the C# hole goes!");
		
		input = Console.ReadLine();
		if(input=="yes") {
			Console.WriteLine("You Have no idea");
		}
		else {
			Console.WriteLine("\nYou have no choice in the Matter.");
		}
	}
}
//end of code
