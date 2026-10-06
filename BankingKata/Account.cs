using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankingKata
{
    public class Account
    {
        private List<Transaction> Transactions = new List<Transaction>();

        public void Deposit(decimal amount)
        {
            Transaction transaction = new Transaction
            {
                Date = DateTime.Now,
                Amount = amount
            };
            Transactions.Add(transaction);
        }

        public void Withdraw(decimal amount)
        {
            Transaction transaction = new Transaction
            {
                Date = DateTime.Now,
                Amount = -amount
            };
            Transactions.Add(transaction);
        }

        public string PrintStatement()
        {
            return Transactions.Sum(x => x.Amount).ToString("F2");
        }
    }
}
