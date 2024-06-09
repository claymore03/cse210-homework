public class Scripture
{
    private string _scripture;

    public Scripture()
    {
        _scripture = "I will go and do the things which the Lord hath commanded...";
    }

    public string DisplayScripture()
    {
        string phrase = $"{_scripture}";
        return phrase;
    }
}