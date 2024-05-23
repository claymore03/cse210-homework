public class Entry{
    public string _date = Convert.ToString(DateTime.Now);
    

    public string _prompt;
    public string _entry;

     public Entry()
        {
        
        }

    public void DisplayDate()
        {

            Console.WriteLine($"{_date}");
        }

    
    public void WriteNewEntry()
    {
        _entry = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_entry}");
    }


}