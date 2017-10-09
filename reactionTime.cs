using System;
using System.Diagnostics;

public class reactionTime
{
	public static void Main(string[]args)
	{
		
		Stopwatch stopwatch = new Stopwatch();
		Random random = new Random();
		
		Console.Clear();
		Console.Write("This program will test reaction Time.\n when you press enter the program will start a random timer once the itmer ends the screen will flash; when this happens press any key as quickly as possible.");
		
		Console.ReadLine();
		Console.Clear();
		System.Threading.Thread.Sleep(random.Next(2500,10000));
		stopwatch.Start();
		Console.BackgroundColor = ConsoleColor.Blue;
		Console.Clear();
		
		Console.ReadLine();
		stopwatch.Stop();
		Console.BackgroundColor = ConsoleColor.Black;
		Console.Clear();
		
		Console.Write("Time taken: {0}", stopwatch.Elapsed);
		
		
	}
}