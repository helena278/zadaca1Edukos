using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca1Edukos
{
     public interface IBankAccount
    {

        decimal Deposit(decimal amount);
        decimal Withdraw(decimal amount);
        

    }
}
