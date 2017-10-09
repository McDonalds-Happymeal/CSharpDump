using System;

public class studentGrade
{
	public static void Main(string[]args)
	{
		string result=null;
		int grade = Convert.ToInt32(Console.ReadLine());
		
		if(grade >= 0 && grade <=39) {
			result = "Fail";
		}
		if(grade >= 40 && grade <=49) {
			result= "Third class (Grade D)";
		}
		if(grade >= 50 && grade <=59) {
			result= "Lower second (Grade C)";
		}
		if(grade >= 60 && grade <=69) {
			result= "Upper second (Grade B)";
		}
		if(grade >= 70 && grade <=100) {
			result= "First class (Grade A)";
		}
		
		Console.Write(result);
	}
}