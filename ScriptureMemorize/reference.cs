using System;

public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;

    public Reference()
    {
        book = "2 Nephi";
        chapter = 2;
        verse = 25;
    }

    public string getBook() 
    {
        return book;
    }

    public int getChapter()
    {
        return chapter;
    }

    public int getVerse()
    {
        return verse;
    }

    public int getEndVerse()
    {
        return endVerse();
    }
}

