using System.Runtime.CompilerServices;

public class Assignment
{
    private string _studentName;

    private string _topic;

    public string GetName()
    {
        return _studentName;
    }

    public void SetName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string DisplayAssignment()
    {
        return $"{_studentName} - {_topic}";
    }

    // public Assignment(string studentName, string topic)
    // {
    //     _studentName = studentName;
    //     _topic = topic;
    // }

    // public void DisplayAssignment()
    // {
    //     Console.WriteLine($"{_studentName} - {_topic}");
    // }
}