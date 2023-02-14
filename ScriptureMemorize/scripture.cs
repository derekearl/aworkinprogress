using System;

class deReference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public deReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public deReference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse; 
    }


}

