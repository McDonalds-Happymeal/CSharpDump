using System;

public class distances
{
	public static void Main(string[]args)
	{
		Console.WriteLine("input 2 points and i will calculate the euclidian and manhatten distance:");
		
		Console.Write("a coordinates: ");
		double[] a= {Convert.ToDouble(Console.ReadLine()),Convert.ToDouble(Console.ReadLine())};
		
		Console.Write("b coordinates: ");
		double[] b= {Convert.ToDouble(Console.ReadLine()),Convert.ToDouble(Console.ReadLine())};
		
		double[] change = {Math.Abs(a[0]-b[0]),Math.Abs(a[1]-b[1])};
		double euclidian = Math.Sqrt((Math.Pow(change[0],2)+Math.Pow(change[1],2)));
		
		Console.WriteLine("The manhatten distance is :{0}.\nAnd Euclidian is : {1}",change[0]+change[1],euclidian);
	}
}