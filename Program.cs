using System;
using Basic_Csharp;

class Program
{
    static void PrintPrimes(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        /*Console.Write("Enter a number : ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime numbers up to {n} are:");
        PrintPrimes(n);*/
        Unique_Char.UniqueChar();
    }
}