using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string pattern = @"\+359( |-)[2]\1\d{3}\1\d{4}\b";

            MatchCollection numbers = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
