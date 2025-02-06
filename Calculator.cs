namespace Basic_Csharp
{
    public class Calculator
    {
        public static void LetsCalculate()
        {
            while (true)
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("select an option between 1-5");
                Console.WriteLine("_________________________________");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("please enter a number between 1 to 5");
                    continue;
                }
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice! Please select number between 1 and 4");
                    continue;
                }
                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator");
                    break;
                }

                double num1, num2;
                Console.Write("Enter the first number: ");
                if(!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid Input! Please enter a valid number");
                    continue;
                }
                Console.Write("Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid Input! Please enter a valid number");
                    continue;
                }
                double result = 0;
                bool validOperation = true;
                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed");
                            validOperation = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                }
                if (validOperation)
                {
                    Console.WriteLine($"The result is {result}");
                }

            }
            Console.WriteLine("Thank you for using the calculator");
        }
    }
}
