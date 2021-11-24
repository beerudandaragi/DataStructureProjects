using Simple_Balanced_Parentheses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBalancedParentheses
{
    class BalancedParenthesesProgram
    {
        public static void BalancedParentheses()
        {
            Utility BalancedParenthesesUTL = new Utility();
            Console.WriteLine("Enter your Expression");
            //This is our Expression string
            string ExpressionString = Console.ReadLine();
            BalancedParenthesesUTL.BalancedExpression(ExpressionString);
        }
    }
}
    