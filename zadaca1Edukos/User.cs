using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca1Edukos
{
    class User: Person,IBankAccount
    {
        

        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

       


        public User (int accountNUmber, decimal balance)
        {
            AccountNumber = accountNUmber;
            Balance = balance;
        }

        public decimal Deposit(decimal amount)
        {
            Balance = Balance + amount;

            return Balance;
        }

        public decimal Withdraw( decimal amount)
        {
            

            if (amount > Balance )
            {
                Console.WriteLine("Error!Insufficient amount on the account!");
            }

            if(amount < Balance)
            {
                Balance = Balance - amount;
            }

            return Balance;
        }

       
    }
}
