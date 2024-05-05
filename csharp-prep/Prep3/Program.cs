using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to 'Guess My Number'!");

        Random rd = new Random();

        int rand_num = rd.Next(1,100);

        Console.WriteLine("What is the magic number? " + rand_num);

        Console.Write("Enter your guess (Pick a number between 1 and 100)");
        string guess = Console.ReadLine();

        while (Convert.ToInt32(guess) != rand_num) 
        {

            Console.WriteLine("You guessed " + guess);

           if (Convert.ToInt32(guess) < rand_num) 
            {
                Console.WriteLine("Higher");
            } 
            else if (Convert.ToInt32(guess) > rand_num) 
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("That's awkward");
            }

            Console.WriteLine("Try again! (Pick a number between 1 and 100)");
            guess = Console.ReadLine(); 
            
        }

        Console.WriteLine("Congratulations! You guessed the magic number!");
        
        
    }
}