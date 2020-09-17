using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordChecker
{
    public class Tools
    {
        public Tools()
        {

        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        public static void ContainsTest()
        {
            string loudWord = "LASDAD";
            string quietWord = "pssst";
            string mixedWord = "lkaAWEkasfkEW";

            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string lowercase = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Running \"tests...\"");
        }
    }
}
