public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _finalVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _finalVerse = -1; 
    }

    public Reference(string book, int chapter, int startVerse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _finalVerse = finalVerse;
    }

    public string GetDisplayText()
    {
        if (_finalVerse != -1)
        {
            return $"{_book} {_chapter}:{_verse}-{_finalVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}
