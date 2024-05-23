public class Journal
{
    public List<string> _promptList = new List<string>();

    public List<Entry> _entriesList = new List<Entry>();

    public string _filePath;

    public Journal()
        {

            _promptList.Add("What was the weather like today?");
            _promptList.Add("What was the most memorable thing that happened to you today?");
            _promptList.Add("If you could change something about today, what would it be?");
            _promptList.Add("How did you see the hand of the Lord in your life today?");
            _promptList.Add("Who did you interact with today?");
            
        }
    public void DisplayRandomPrompt()
           {
            Random rd = new Random();
                int rand_num = rd.Next(0,4);

            Console.WriteLine($"{_promptList[rand_num]}");
        
           }
    
    public void DisplayEntries()
    {
        foreach (Entry entry in _entriesList)
        {
            entry.DisplayEntry();
        }
    }
   
        
}