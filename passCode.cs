using System;

public class passCode
{
    public static void Main(string[]args)
    {
        char[] answer = {'1','2','5','3','5'};

        Console.WriteLine("how many guesses");
        int guesses = Convert.ToInt32(Console.ReadLine());
        char[] guess = new char[5];
        int sum, c, correct;
        for(int z=guesses;z>=0;z--)
        {
            Console.Write("\nwhat is your guess: ");
            guess = Console.ReadLine().ToCharArray();
            c = 0;
            sum=0;
            correct=0;
            foreach(char i in guess)
            {
                if (i==answer[c])
                {
                    correct++;
                    sum = sum + Int32.Parse(i.ToString());
                }
                c++;
            }

            Console.WriteLine("you got {0} digits correct that sum to {1}",correct,sum);
            if (correct == 5){
                Console.WriteLine("well done you win.");
            }
        }
    }
}