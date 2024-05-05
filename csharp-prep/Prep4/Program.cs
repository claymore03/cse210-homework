// Name: Clayton Redding
// Instructor: Brother Gibbons
// Class: CSE 210
// Date: 05/04/2024
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        Console.Write("Add any number to the list! Type '0' when finished.");
        int number = Convert.ToInt32(Console.ReadLine());
        
        while (number != 0)
        {
            numberList.Add(number);
            Console.Write("Add another number? Type '0' when finished.");
            number = Convert.ToInt32(Console.ReadLine());
        } 
        
        int length = numberList.Count;
        // Console.WriteLine("Length of list: " + length);
        
        int sum = 0;
        foreach (int num in numberList)
        {
            sum += num;
        }

        int average = sum / length;

        int max = numberList.Max();

        Console.WriteLine("The sum of your list is: " + sum);

        Console.WriteLine("The average is: " + average);

        Console.WriteLine("The largest number is: " + max);
        
        // for(int i=0;i<numberList.Count;i++)
        // {
        // Console.WriteLine(numberList[i]);
        // }
    }
}