//Name: Clayton Redding
//Date: 4/27/2024
//Class: CSE 210
//Instructor: Brother Gibbons
using System;

class Program
{
    static void Main(string[] args)
    {        
        Console.Write("Enter your grade precentage (0 - 100)? ");
        string grade = Console.ReadLine();

        string letter = "";


        if (Convert.ToInt32(grade) < 60) 
        {
            letter = "F";
        } 
        else if (Convert.ToInt32(grade) >= 60 && Convert.ToInt32(grade) < 70) 
        {
            letter = "D";
        }
        else if (Convert.ToInt32(grade) >= 70 && Convert.ToInt32(grade) < 80) 
        {
            letter = "C";
        }
        else if (Convert.ToInt32(grade) >= 80 && Convert.ToInt32(grade) < 90) 
        {
            letter = "B";
        }
        else if (Convert.ToInt32(grade) >= 90 && Convert.ToInt32(grade) < 101) 
        {
            letter = "A";
        }    
        else 
        {
            Console.Write("That's awkward.");
        }

        Console.WriteLine($"Your grade is: " + letter);

        if (Convert.ToInt32(grade) < 70) 
        {
            Console.Write("You did not pass the course. Study harder next time. Don't give up!");
        } 
        else if (Convert.ToInt32(grade) >= 70 && Convert.ToInt32(grade) < 101) 
        {
            Console.Write("Congratulations! You passed the course.  Well done.");
        }
    }
}