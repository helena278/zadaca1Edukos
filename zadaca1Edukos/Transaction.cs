using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca1Edukos
{
    public abstract class Transaction : ITransaction
    {
        public DateTime Date;
        public decimal Amount;

        public abstract void MakeTransaction();

        void ITransaction.MakeTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
