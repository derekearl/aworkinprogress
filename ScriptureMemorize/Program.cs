using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        string book = reference.getBook();
        Console.WriteLine(book);
    }
}