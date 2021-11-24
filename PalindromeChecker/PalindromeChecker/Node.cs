using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    public class Node
    {
        public Node Next;
        public Object data;
        //constructor for saving the data to node.data
        public Node(Object Val)
        {
            data = Val;
        }
    }
}