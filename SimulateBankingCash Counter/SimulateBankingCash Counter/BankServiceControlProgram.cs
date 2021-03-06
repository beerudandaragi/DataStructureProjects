using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateBankingCash_Counter
{
    class BankServiceControlProgram
    {
        Node head;
        public void BankQueueService(int Select)
        {
            //Depending on Selection it will operate
            switch (Select)
            {
                //option is one then add customer to Queue
                case 1:
                    EnQueue();
                    Console.WriteLine(".......+........+.......+........+........+.........+.......");
                    break;
                //this is the service given to customer
                case 2:
                    if (IsEmpty())
                    {
                        Console.WriteLine("Queue is empty");
                    }
                    else
                    {
                        Console.WriteLine("1 for withdraw\n2 for Deposit");
                        int ServiceID = int.Parse(Console.ReadLine());
                        Console.Write(Front());
                        if (ServiceID == 1)
                        {
                            Console.WriteLine(" Wthdrawing money");
                        }
                        else
                            Console.WriteLine(" Depositing a money");
                        Console.WriteLine("Thank you your turn over....");
                        //After giving service to customer it deletes the entry
                        DeQueue();
                    }
                    Console.WriteLine(".......+........+.......+........+........+.........+.......");
                    break;
                //Gives the confirmation to is queue is empty or not
                case 3:
                    Console.WriteLine(IsEmpty());
                    Console.WriteLine(".......+........+.......+........+........+.........+.......");
                    break;
                //Gives the size of the ayyay    
                case 4:
                    Console.WriteLine(Size());
                    Console.WriteLine(".......+........+.......+........+........+.........+.......");
                    break;
                case 5:
                    Queue();
                    Console.WriteLine(".......+........+.......+........+........+.........+.......");
                    break; ;
                default:
                    break;
            }
        }

        public void Queue()
        {
            Node CurrentNode = head;
            Console.WriteLine("Queue is Created");
            return;
        }
        //It gives the front end user details
        public string Front()
        {
            Node Current = head;
            return (string)Current.data;
        }

        //Add entry to list
        public void EnQueue()
        {
            Node CurrentNode = head;
            Console.WriteLine("Enter Customer name");
            string CName = Console.ReadLine();
            Node TempNode = new Node(CName);
            if (head == null)
            {
                head = TempNode;
                return;
            }
            while (CurrentNode.Next != null)
            {
                CurrentNode = CurrentNode.Next;
            }
            CurrentNode.Next = TempNode;
            return;
        }

        //Eliminates the user turn
        public void DeQueue()
        {
            Node Current = head;
            //it will check untill last node
            head = Current.Next;
        }

        //Queue Size
        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }
            Node Current = head;
            int Size = 0;
            while (Current.Next != null)
            {
                Size++;
                Current = Current.Next;
            }
            return Size + 1;
        }

        //it will returns the Empty or not status
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
    }
}
    