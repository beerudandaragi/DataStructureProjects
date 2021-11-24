using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class PalindromeCheckingProgram
    {
        public static void PalindromeChecking()
        {
            Deque DequeUTL = new Deque();
            Console.WriteLine("Enter Your String");
            string CheckString = Console.ReadLine();
            //we have to add front all the elements in the string
            for (int i = 0; i < CheckString.Length; i++)
            {
                DequeUTL.addFront(CheckString[i]);
            }
            //
            DequeUTL.Display();
            Console.WriteLine();
            Console.WriteLine(DequeUTL.IsPalindrome(CheckString));
        }

    }
}
