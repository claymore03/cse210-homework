public class Entry{
    public string _date = Convert.ToString(DateTime.Now);
    public List<int> _promptList = new List<int>();

    public string _prompt;
    public string _entry;

     public Entry()
        {
        
        }

    public void DisplayDate()
        {

            Console.WriteLine($"The current date is: {_date}");
        }

    public void DisplayPrompt()
    {
        Console.WriteLine("What is something you are grateful for?");
    }
    public void WriteNewEntry()
    {
        Console.Write("Write a response: ");
        _entry = Console.ReadLine();
    }


}