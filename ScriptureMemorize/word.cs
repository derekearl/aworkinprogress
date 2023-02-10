using System;

private class Word
{
    private static System.Random random = new System.Random();

    private static int GenerateRandomNumber()
    {
        return random.Next(2, 6);
    }
}