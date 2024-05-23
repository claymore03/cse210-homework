using System;

class Program
{
    static void Main(string[] args)
    {
        
        Entry entry = new Entry();
        Journal myJournal = new Journal();
        
        Console.WriteLine("Welcome to Journaltron 2000");
        Console.WriteLine("1. Write.\n2. Display.\n3. Load.\n4. Save.\n5. Quit\n");
        Console.Write("Select an option: ");
        int selection = Convert.ToInt32(Console.ReadLine());

        while (selection != 5){
            if (selection == 1)
            {
                //Write a new entry
                entry.DisplayDate();
                myJournal.DisplayRandomPrompt();
                entry.WriteNewEntry();
                myJournal._entriesList.Add(entry);
            }
            else if (selection == 2)
            {
                //Display entries
                myJournal.DisplayEntries();
            }
            else if (selection == 3)
            {
                //Load journal
            }
            else if (selection == 4)
            {
                //Save journal
            }
            else
            {
                Console.WriteLine("Invalid selection! Please, select a number between 1 and 5.");
            }

            Console.WriteLine("1. Write.\n2. Display.\n3. Load\n4. Save.\n5. Quit\n");
            Console.Write("Select an option: ");
            selection = Convert.ToInt32(Console.ReadLine());
        }
    }

        

        
}
