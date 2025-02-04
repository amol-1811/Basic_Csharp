namespace Basic_Csharp
{
    public class PersonAge
    {
        public static void GetPersonAge()
        {
            Console.Write("Enter your birth date (yyyy-MM-dd):");
            string birthDateInput = Console.ReadLine();

            if (DateTime.TryParse(birthDateInput, out DateTime birthDate))
            {
                DateTime currentDate = DateTime.Today;

                if (birthDate > currentDate)
                {
                    Console.WriteLine("Invalid birth date. The birth date cannot be in the future.");
                }
                else
                {
                    int age = currentDate.Year - birthDate.Year;

                    if (birthDate.Date > currentDate.AddYears(-age))
                    {
                        age--;
                    }

                    Console.WriteLine($"Your age is {age} years.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter your birth date in the format yyyy-MM-dd.");
            }
        }
    }
}
