using System;

public class Program
{
    public static void Main()
    {
        IspisiNaEkran("Hello World");
    }
    public static void IspisiNaEkran(string text)
    {
        Console.WriteLine(text);
        IspisiNaEkran(text);
    }
}