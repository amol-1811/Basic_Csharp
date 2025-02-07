using System;
using System.Collections.Generic;
using System.Globalization;

namespace Basic_Csharp
{
    public class WorkDays
    {
        public static void GetWorkDays()
        {

                // Get input dates from the user (or you can set them directly)
                Console.Write("Enter the start date (yyyy-MM-dd): ");
                string startDateString = Console.ReadLine();

                Console.Write("Enter the end date (yyyy-MM-dd): ");
                string endDateString = Console.ReadLine();


                if (DateTime.TryParseExact(startDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate) &&
                    DateTime.TryParseExact(endDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate))
                {

                    if (startDate > endDate)
                    {
                        Console.WriteLine("Error: Start date must be before the end date.");
                        return; // Exit the program
                    }


                    int workdays = CalculateWorkdays(startDate, endDate);
                    Console.WriteLine($"Number of workdays between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}: {workdays}");
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please use yyyy-MM-dd.");
                }
            }

            public static int CalculateWorkdays(DateTime startDate, DateTime endDate)
            {
                int workdays = 0;
                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    if (date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday)
                    {
                        workdays++;
                    }
                }
                return workdays;
            }
        
    }
    
}
