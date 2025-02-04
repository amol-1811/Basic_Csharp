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
            HashSet<char> charSet = new HashSet<char>();

            foreach (char c in str)
            {
                if (!charSet.Add(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
