using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca1Edukos
{
    class Bank
    {

        private  List<User> users;
        private List<Transaction> transactions;
        public Bank()
        {
            users = new List<User>();
            transactions = new List<Transaction>();
        }

        public Bank(List<User> users) : this()
        {
            this.users = users;
        }

        public Bank(List<Transaction> transactions) : this()
        {
            this.transactions = transactions;
        }



        public void AddUser(User user)
        {
            if (users == null)
                users = new List<User>();
            users.Add(user);
        }


        public void RemoveUser(User user)
        {

            users.Remove(user);

        }

        public void MakeTransaction(Transaction transaction)
        {
            if (transactions == null)
                transactions = new List<Transaction>();
            transaction.MakeTransaction();
            transactions.Add(transaction);
        }
    }
}
