using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment_1
{
    class Account
    {
        private static int accountNumber=0;
        private string accountName;
        private double balance;
        private Address address;



      
        public Account( string accountName, double balance, Address address)
        {
            //this.accountNumber = accountNumber;
            accountName++;
            this.accountName = accountName;
            this.balance = balance;//storing value 
            this.address = address; //storing a obj reference
        }
       /* public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }*/
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }

        public void Deposit(double amount )
        {
            balance = balance + amount;
        }



        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
          
        }


    }
}
