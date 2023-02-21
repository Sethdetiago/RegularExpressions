using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                       //FileIO
using System.Configuration;
using System.Text.RegularExpressions; //In order to use regex this is needed.

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input  = System.IO.File.ReadAllText(@"C:\Users\seths\Downloads\inputfile.txt");

            string regularExpression = @"\d{3}|\d{2}";
            Regex numsInFileFormat = new Regex(regularExpression);

            MatchCollection matches = numsInFileFormat.Matches(input); //create a collection of all matches between the regex and
                                                                       //the text in the file

            List<Char> nums = new List<Char>(); //Create list to store numbers found
            foreach (Match match in matches)
            {
                GroupCollection group = match.Groups;
                if (int.TryParse(group[0].Value, out int result))
                {
                    nums.Add((char)result);     // add each int to the list
                }
            }

            foreach (char num in nums)
            {
                Console.Write(num); //prints out the numbers casted to Chars "of succes. It is part of ssuccess
            }

            Console.ReadKey();


        }
    }
}
