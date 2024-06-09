using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizor 2000");

        Scripture myScripture = new Scripture();
        Reference myReference = new Reference(1, "Nephi", 3, 7);

       Console.WriteLine(myReference.ReferenceType1());
       Console.WriteLine(myScripture.DisplayScripture());
    }
}