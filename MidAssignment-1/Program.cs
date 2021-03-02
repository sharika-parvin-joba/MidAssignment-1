using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("10-A", "5/1", "dhaka", "BAngladesh");
            address1.GetAddress();
            Account account1 = new Account( 0 , "18-38721-3", 4000.1, address1);
            account1.ShowAccountInformation();
            Bank myBank = new Bank("BAngladesh bank", 50);
            myBank.AddAccount();
            myBank.PrintAccountDetails();

        }
    }
}
