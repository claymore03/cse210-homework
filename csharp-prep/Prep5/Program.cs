using System;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favNum = Console.ReadLine();
        return Convert.ToInt32(favNum);
    }

    static int SquareNumber(int x) 
    {
        return x * x;
    }

    static void DisplayResults(string name, string squaredNum) 
    {
        Console.WriteLine(name + ", the square of your number is " + squaredNum + ".");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResults(name, Convert.ToString(squared));
    }
}