public class Reference
{
    private int _bookNumber;
    
    private string _book;
    
    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    public Reference()
    {
        _bookNumber = 0;
        
        _book = "";

        _chapter = 0;

        _startVerse = 0;

        _endVerse = 0;
    }
    
    public Reference(string bookName, int chapterNum, int verse1)
    {
        _book = bookName;

        _chapter = chapterNum;

        _startVerse = verse1;
    }

    public Reference(string bookName, int chapterNum, int verse1, int verse2)
    {  
        _book = bookName;

        _chapter = chapterNum;

        _startVerse = verse1;

        _endVerse = verse2;
    }

    public Reference(int bookNum, string bookName, int chapterNum, int verse1, int verse2)
    {
        _bookNumber = bookNum;
        
        _book = bookName;

        _chapter = chapterNum;

        _startVerse = verse1;

        _endVerse = verse2;
    }

    public Reference(int bookNum, string bookName, int chapterNum, int verse1)
    {
        _bookNumber = bookNum;
        
        _book = bookName;

        _chapter = chapterNum;

        _startVerse = verse1;
    }

    public string ReferenceType4()
    {
        string text = $"{_bookNumber}{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return text;
    }

    public string ReferenceType3()
    {
        string text = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return text;
    }

    public string ReferenceType2()
    {
        string text = $"{_bookNumber}{_book} {_chapter}:{_startVerse}";
        return text;
    }

    public string ReferenceType1()
    {
        string text = $"{_book} {_chapter}:{_startVerse}";
        return text;
    }

}