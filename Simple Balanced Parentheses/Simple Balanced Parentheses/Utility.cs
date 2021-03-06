using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Balanced_Parentheses
{
    class Utility
    {
        Node head;
        public void BalancedExpression(string UserExpression)
        {
            StackMemory StackMemoryUTL = new StackMemory();
            int Length = UserExpression.Length;
            //it will checks all the elements in string
            for (int i = 0; i < Length; i++)
            {
                //if "(" then it push it to stack
                if (UserExpression[i] == '(')
                {
                    StackMemoryUTL.push(UserExpression[i]);
                }
                //if ")" then it pop it from stack
                if (UserExpression[i] == ')')
                {
                    int RetrunValue = StackMemoryUTL.pop();
                    //if the return value -2 means stack is already empty then no more pop is possible and exit
                    if (RetrunValue == -2)
                    {
                        Console.WriteLine("This is not balanced expression");
                        Environment.Exit(0);
                    }
                }
            }
            //after all the elements in string checks and if the stack is empty then expression is balanced
            if (StackMemoryUTL.IsEmpty())
            {
                Console.WriteLine("This is balanced Expression");
            }
            //Else not balanced tree
            else
            {
                Console.WriteLine("This is not balanced expression");
            }
            //it shows the cahracter at stack at the top
            Console.WriteLine((char)StackMemoryUTL.peek());
            //it shows the how much stack is filled
            Console.WriteLine(StackMemoryUTL.Size());
        }
    }
}
