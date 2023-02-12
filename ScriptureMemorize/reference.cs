using System;

public class Reference
{
    private string wipbook;
    private int wipchapter;
    private int wipverse;
    private int wipendVerse;

    public Reference()
    {
        wipbook = "2 Nephi";
        wipchapter = 2;
        wipverse = 24;
        wipendVerse = 25;
    }

    public string getBook() 
    {
        return wipbook;
    }

    public int getChapter()
    {
        return wipchapter;
    }

    public int getVerse()
    {
        return wipverse;
    }

    public int getEndVerse()
    {
        return wipendVerse;
    }
}

