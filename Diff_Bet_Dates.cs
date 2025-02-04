namespace Basic_Csharp
{
    public class Diff_Bet_Dates
    {
        public static void Days_after_diff()
        {
            Console.WriteLine("Enter the first date (yyyy-MM-dd):");
            string firstDateInput = Console.ReadLine();

            Console.WriteLine("Enter the second date (yyyy-MM-dd):");
            string secondDateInput = Console.ReadLine();

            if (DateTime.TryParse(firstDateInput, out DateTime firstDate) &&
                DateTime.TryParse(secondDateInput, out DateTime secondDate))
            {
                TimeSpan difference = secondDate - firstDate;

                int absoluteDifference = Math.Abs(difference.Days);

                Console.WriteLine($"The difference between the two dates is {absoluteDifference} days.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter dates in the format yyyy-MM-dd.");
            }
        }
    }
}
