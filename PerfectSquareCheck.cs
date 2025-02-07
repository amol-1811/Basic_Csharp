using System.ComponentModel.Design;

namespace Basic_Csharp
{
    public class PerfectSquareChecker
    {
        public static void CheckPerfectSuare()
        {
            Console.WriteLine("Enter a number : ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (isPerfectSquare(number))
                {
                    Console.WriteLine($"{number} is a perfect square");
                }
                else
                {
                    Console.WriteLine($"{number} is not a perfect square");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
        public static bool isPerfectSquare(int number)
        {
            double sqrt = Math.Sqrt(number);
            return sqrt == Math.Floor(sqrt);
        }
    }
}
