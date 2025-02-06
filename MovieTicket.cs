namespace Basic_Csharp
{
    public class MovieTicket
    {
        const double ChildPrice = 50;
        const double AdultPrice = 100;
        const double SeniorPrice = 75;
        public static void GetMovieTicket()
        {
            Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the time of show between 1 to 24:");
            int time = Convert.ToInt32(Console.ReadLine());

            bool isMatinee = time > 12 && time < 18;

            double ticketPrice = CalculateTicket(age, isMatinee);  
            if(age < 0)
            {
                Console.WriteLine("Invalid Age");
            }
            else
            {
                Console.WriteLine($"The ticket price is {ticketPrice}");
            }
        }
        static double CalculateTicket(int age, bool isMatinee)
        {
            double TicketPrice = 0;
            if(age < 13)
            {
                TicketPrice = ChildPrice;
            }
            else if (age >= 13 && age < 65)
            {
                TicketPrice = AdultPrice;
            }
            else
            {
                TicketPrice = SeniorPrice;
            }
            if (isMatinee == true)
            {
                TicketPrice = TicketPrice * 0.1;
            }
            return TicketPrice;
        }

    }
}
