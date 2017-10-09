using System;

public class Calculator
{
	public static void Main (string[]args)
	{
		string input=null;
		Calculator Function = new Calculator();
		
		Console.Clear();
		Console.Write("Type HELP for list of operation; Type EXIT to QUIT at any time");
		Console.WriteLine("\n\n\n\t\t\t\t╔══════════╗");
		Console.WriteLine("\t\t\t\t║CALCULATOR║");
		Console.WriteLine("\t\t\t\t╚══════════╝ .EXE");
		
		Console.WriteLine("\n\n");
		
		Console.Write("What is Your Operation: ");
		
		input = Console.ReadLine();
		//input = number.InputScan(input);
		
		switch (input)
		{
			case "exit":
				Function.Quit();
				break;
				
			
			default: 
				Console.WriteLine(input + " is not recognised");
				break;
		}
		
		//Console.Write(input);
	}
	
	public string inputmanger (string input)
	{
		switch (input)
		{
			case "exit":
			case "Exit":
			case "EXIT":
			case "quit":
			case "Quit":
			case "QUIT":
				Function.Quit();
				break;
				
			
			default: 
				Console.WriteLine(input + " is not recognised");
				break;
		}
		return input;
	}
	
	public void Quit()
	{
		Console.Clear();
		Console.Write("\nProgram will now exit press any key to close: ");
		Console.ReadLine();
		Environment.Exit(0);
	}
}