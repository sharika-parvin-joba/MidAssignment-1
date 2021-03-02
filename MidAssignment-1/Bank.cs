using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment_1
{
    class Bank
    {
        private string bankName;
        private Account[] accounts;



        public Bank(string name, int size)
        {
            this.bankName = name;
            accounts = new Account[size];
        }



        public string Name
        {
            set { this.Name = value; }
            get { return this.Name; }
        }
        public Account[] Accounts { 
            set { this.accounts = value; }
            get { return this.accounts; }
        }
        public void PrintAccountDetails()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i].ShowAccountInformation();
            }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }

    }
}
