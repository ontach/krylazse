using System;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 1;
        int b = int.MaxValue;

        while (a != 0)
        {
            Console.Write("Wprowadz liczbe: ");
            if (int.TryParse(Console.ReadLine(), out a))
            {
                if (b > a)
                {
                    b = a;
                }
            }
            else
            {
                Console.WriteLine("Nieprawidlowe dane wejsciowe.");
            }
        }

        Console.WriteLine("Najmniejsza liczba: " + b);
    }
}