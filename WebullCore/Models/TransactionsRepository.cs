using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebullCore.Models
{
    public class TransactionsRepository : ITransactionsRepository
    {
        private readonly WebullContext _context;
        public TransactionsRepository(WebullContext context)
        {
            _context = context;
        }

        public IEnumerable<Transactions> GetTransactions()
        {
            return _context.Transactions;
        }

        public Transactions AddTransaction(Transactions transaction)
        {

            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            return transaction;
        }

        public Transactions GetTransactionById(int id)
        {
            return _context.Transactions.Find(id);
        }

        public Transactions UpdateTransaction(Transactions transaction)
        {

            Transactions transaactionToUpdate =_context.Transactions.Find(transaction.Id);

            transaactionToUpdate.StartDate = transaction.StartDate;
            transaactionToUpdate.StartPrice = transaction.StartPrice;
            transaactionToUpdate.Symbol = transaction.Symbol;
            transaactionToUpdate.Shares = transaction.Shares;
            transaactionToUpdate.EndDate = transaction.EndDate;
            transaactionToUpdate.EndPrice = transaction.EndPrice;

            _context.SaveChanges();
            return transaction;
        }
    }
}
