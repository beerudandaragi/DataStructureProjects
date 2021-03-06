using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    public class Deque
    {
        Node head;
        //This is Deque Utility
        //Addfront I'm Using LinkedList Concept here
        //Everey new add front is head
        public void addFront(char Value)
        {
            Node Current = head;
            Node TempNode = new Node(Value);
            if (IsEmpty())
            {
                head = new Node(Value);
                return;
            }
            TempNode.Next = Current;
            head = TempNode;
        }

        //at the rear end reach till next.null then add node there
        public void addRear(char Value)
        {
            Node Current = head;
            Node TempNode = new Node(Value);
            if (IsEmpty())
            {
                head = new Node(Value);
                return;
            }
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = TempNode;
        }

        //it removes front and send element and head is switch to .next
        public char RemoveFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                Environment.Exit(0);
            }
            Node Current = head;
            char CharValue;
            if (Current.Next == null)
            {
                CharValue = Convert.ToChar(Current.data);
                head = null;
                return CharValue;
            }
            CharValue = Convert.ToChar(Current.data);
            head = Current.Next;
            return CharValue;
        }

        //remove the rear and give char data
        public char RemoveRear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                Environment.Exit(0);
            }
            Node Current = head;
            char CharValue;
            if (Current.Next == null)
            {
                return Convert.ToChar(Current.data);
            }
            while (Current.Next.Next != null)
            {
                Current = Current.Next;
            }
            CharValue = Convert.ToChar(Current.Next.data);
            Current.Next = null;
            return CharValue;
        }

        //If head is null then it return true
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }

        //vounts how many nodes there in linked list
        public int Size()
        {
            Node Current = head;
            int Ans = 0;
            if (IsEmpty())
            {
                return 0;
            }
            while (Current.Next != null)
            {
                Ans++;
            }
            return Ans + 1;
        }

        //Display all the data in nodes
        public void Display()
        {
            Node Current = head;
            if (IsEmpty())
            {
                return;
            }
            while (Current.Next != null)
            {
                Console.Write(Convert.ToChar(Current.data));
                Current = Current.Next;
            }
            Console.Write(Convert.ToChar(Current.data));
        }
        //This is checking the palindrome or not it returns true or false
        public bool IsPalindrome(string Value)
        {
            if (IsEmpty())
            {
                return false;
            }
            Node Current = head;
            string TempString = string.Empty;
            while (Current.Next != null)
            {
                TempString += RemoveFront();
                Current = Current.Next;
            }
            TempString += RemoveFront();
            if (TempString.Equals(Value))
            {
                return true;
            }
            else
                return false;
        }
    }
}