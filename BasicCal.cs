using System;
public class BasicCal
{
    public static void Main(string[]args)
    {
        double z = 0;
        Console.WriteLine("This is a Basic calculator insert to numbers and then a operator and this will calculate the result. Operator are /, *, +, -, %");

        Console.Write("\nValue x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nValue y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nOperator: ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                z = x+y;
            break;
            case '-':
                z = x-y;
            break;
            case '/':
                z = x/y;
            break;
            case '*':
                z = x*y;
            break;
            case '%':
                z = x%y;
            break;
            default:
            Console.WriteLine("WRONG CODE");
            break;
        }

        Console.WriteLine("{0} {1} {2} = {3}",x,op,y,z);
    }
}