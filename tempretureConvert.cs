using System;

public class tempretureConvert
{
	public static void Main(string[]args)
	{
		Console.Write("input a tempreture:");
		double temp = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("C or F :" + temp);
		string type = Console.ReadLine();
		
		
		switch (type) {
			case "C":
			case "c":
			temp = (9/5)*temp + 32;
			type = "F";
			break;
			case "F":
			case "f":
			temp = (temp-32)/(9/5);
			type = "C";
			break;
			default: Console.WriteLine("you done goofed");
			break;
		}
		
		
		Console.WriteLine("\nYour converted temp is {0}{1}",temp,type);
	}
}