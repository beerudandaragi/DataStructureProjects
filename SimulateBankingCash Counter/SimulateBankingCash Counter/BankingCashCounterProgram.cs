using SimulateBankingCash_Counter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateBankingCashCounter
{
    class BankingCashCounterProgram
    {
        public static void ServiceSelection()
        {
            //it takes the employee option and keep on asking if you want to exit the app then press 5
            BankServiceControlProgram ServiceSelectionUTL = new BankServiceControlProgram();
            First: Console.WriteLine("Enter your Option\n1: for Entry\n2: for Give a service to Front user Withdrawn/Deposit\n3: for Q is Empty" +
                       "\n4: Q Size\n5: for Exit");
            Home: try
            {
                int Selection = int.Parse(Console.ReadLine());
                if (Selection < 5)
                {
                    ServiceSelectionUTL.BankQueueService(Selection);
                    goto First;
                }
                else
                {
                    Console.WriteLine("Wrong Option");
                }
            }
            //Invalid exceptions are catch here
            catch (Exception)
            {
                Console.WriteLine("Invalid Option");
                goto Home;
            }
        }
    }
}
    