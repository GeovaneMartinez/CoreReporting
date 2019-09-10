using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebullCore.Models
{
    public interface ITransactionsRepository
    {
        IEnumerable<Transactions> GetTransactions();
        Transactions AddTransaction(Transactions transaction);
        Transactions GetTransactionById(int id);
        Transactions UpdateTransaction(Transactions transaction);
    }
}
