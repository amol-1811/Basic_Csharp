using System.Linq;


namespace Basic_Csharp
{
    public class AreAnagramString
    {
        public static void AnagramString()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            if (AreAnagrams(str1, str2))
            {
                Console.WriteLine("The strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams.");
            }
        }

        static bool AreAnagrams(string str1, string str2)
        {
            str1 = str1.Replace(" ", "").ToLower();
            str2 = str2.Replace(" ", "").ToLower();

            return string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c));
        }
    }
}
