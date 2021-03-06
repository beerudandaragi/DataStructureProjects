using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Balanced_Parentheses
{
    class StackMemory
    {
        //Default top is Zero
        //And i have take stack size as 50
        private int Top = -1;
        private int[] Stack = new int[50];

        //top should be increase first then save data to memory
        public void push(int Data)
        {
            Top++;
            Stack[Top] = Data;
        }

        //pop the data then Top decreased by 1
        public int pop()
        {
            int Ans;
            if (Top == -1)
            {
                return -2;
            }
            Ans = Stack[Top];
            Top--;
            return Ans;
        }

        //If the top is -1 then top is empty
        public bool IsEmpty()
        {
            if (Top == -1)
            {
                return true;
            }
            return false;
        }

        //it is the peek function and it returns the value present at top

        public int peek()
        {
            try
            {
                return Stack[Top];
            }
            catch (Exception)
            {
                Console.Write("Your Stack is empty Top : -1");
                //Ascii value for . is 46
                return 46;
            }
        }

        //This is gives Size of the stack
        public int Size()
        {
            return Top + 1;
        }
    }
}