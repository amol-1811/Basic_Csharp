using System.Collections.Generic;

namespace Basic_Csharp
{
    public class Unique_Char
    { 
        public static void UniqueChar()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (HasAllUniqueCharacters(input))
            {
                Console.WriteLine("The string has all unique characters.");
            }
            else
            {
                Console.WriteLine("The string does not have all unique characters.");
            }
        }

        static bool HasAllUniqueCharacters(string str)
        {
            // Use a HashSet to store characters
            HashSet<char> charSet = new HashSet<char>();

            // Iterate through each character in the string
            foreach (char c in str)
            {
                // Try to add the character to the HashSet
                if (!charSet.Add(c))
                {
                    // If Add returns false, the character is already in the HashSet
                    return false;
                }
            }

            // If all characters are added successfully, they are unique
            return true;
        }
    }
}
