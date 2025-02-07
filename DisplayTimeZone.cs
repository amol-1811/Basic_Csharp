namespace Basic_Csharp
{
    public class DisplayTimeZone
    {
        public static void TimeZoneDisplay()
        {
            DateTime dateTime = DateTime.UtcNow;

            string[] timeZones =
            {
                "UTC",
                "Pacific Standard Time",
                "Mountain Standard Time",
                "Central Standard Time",
                "Eastern Standard Time",
                "India Standard Time",
                "China Standard Time",
                "New Zealand Standard Time"
            };
            foreach (string timeZoneId in timeZones)
            {
                TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone);

                Console.WriteLine($"{timeZoneId}: {localTime}");
            }
        }
    }
}
