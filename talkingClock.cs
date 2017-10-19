using System;

public class talkingClock
{
    public static void Main(string[]args)
    {
        Console.Write("Input a Time");
        string input = Console.ReadLine();

        string[] seperated = input.Split(':');
        string end;
        int hour, min;
        string minOutput;

        hour= Convert.ToInt32(seperated[0]);
        min=Convert.ToInt32(seperated[1]);

        string[] teens = {"one", "two" ,"three", "four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
        string[] tens = {"twenty-","thirty-","fourty-","fifty-"};

        end = hour>12 ? "pm" : "asm";
        if (hour>12){hour = hour-12;}

        if (min<20){
            minOutput=teens[min];
        }
        else
        {
            minOutput=tens[(min/10)-2];
            minOutput+=teens[(min%10)-1];
        }

        Console.Write("\nIt's {0} {1} {2}",teens[--hour],minOutput , end);

    }
}