using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        
        Console.WriteLine("Welcome to Journaltron 2000");

        entry1.DisplayDate();
        entry1.DisplayPrompt();
        entry1.WriteNewEntry();
    }
}