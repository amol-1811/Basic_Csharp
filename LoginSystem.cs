namespace Basic_Csharp
{
    public class LoginSystem
    {
        public static void Login()
        {
            string correctUsername = "user123";
            string correctPassword = "Password123";
            int maxAttempt = 3;

            Console.WriteLine("Welcome to the Login System!");

            for (int i = 0; i < maxAttempt; i++)
            {
                Console.Write("Enter your username: ");
                string enteredUsername = Console.ReadLine();

                Console.Write("Enter your password: ");
                string enteredPassword = Console.ReadLine();

                if (enteredUsername == correctUsername && enteredPassword == correctPassword)
                {

                    Console.WriteLine("Login successful!");
                    break;
                }
                else if(enteredUsername == correctUsername && enteredPassword != correctPassword)
                {
                    Console.WriteLine("Incorrect password.");
                }
                
                else if(enteredUsername != correctUsername && enteredPassword == correctPassword)
                {
                    Console.WriteLine("Incorrect username.");
                }
                else
                {
                    Console.WriteLine("Incorrect username and password.");
                }
            }
            Console.WriteLine("Account is locked!! exceed maximum attempts.");
        }
    }
}
