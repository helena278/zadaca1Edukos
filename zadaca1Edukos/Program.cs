using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca1Edukos
{
    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();

            User user1 = new User(123456789, 229.30M)
            {
                FirstName = "Helena",
                LastName = "Andrasek",
                AccountNumber = 123456789,
                OIB = 1122334455,
                Balance = 229.30M,

                
            };
            user1.Deposit(600);

            bank.AddUser(user1);

            User user2 = new User(987654321, 332.66M)
            {
                FirstName = "Johnny",
                LastName = "Depp",
                AccountNumber = 987654321,
                OIB = 334456578,
                Balance = 332.66M
            };
            user2.Withdraw(200);

            bank.AddUser(user2);

            Console.WriteLine($"User num. {user1.AccountNumber} -- {user1.FirstName} {user1.LastName} with OIB number {user1.OIB} has {user1.Balance} in the account");
            Console.WriteLine($"User num. {user2.AccountNumber} -- {user2.FirstName} {user2.LastName} with OIB number {user2.OIB} has {user2.Balance} in the account");
            Console.ReadKey();

        }
    }













}
    

