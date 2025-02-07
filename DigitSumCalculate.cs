namespace Basic_Csharp
{
    public class DigitSumCalculator
    {
        public static void SumOfDigits()
        {
            Console.WriteLine("Enter an integer number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int evenSum = 0;
                int oddSum = 0;
                int posiNumber = Math.Abs(number);

                while (posiNumber > 0)
                {
                    int digit = posiNumber % 10;
                    if (digit % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    posiNumber /= 10;
                }
                Console.WriteLine($"Sum of even digits: {evenSum}");
                Console.WriteLine($"Sum of odd digits: {oddSum}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer number.");
            }
        }
    }
}
