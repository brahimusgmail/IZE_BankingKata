using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankingKata
{
    // Cette classe représente un compte bancaire qui peut effectuer des dépôts et des retraits, et générer un relevé de compte.
    public class Account
    {
        // liste des transactions effectuées sur le compte
        private List<Transaction> Transactions = new List<Transaction>();

        // Méthode pour effectuer un dépôt sur le compte
        public void Deposit(decimal amount)
        {
            Transaction transaction = new Transaction
            {
                Date = DateTime.Now,
                Amount = amount
            };
            Transactions.Add(transaction);
        }

        // Méthode pour effectuer un retrait sur le compte
        public void Withdraw(decimal amount)
        {
            Transaction transaction = new Transaction
            {
                Date = DateTime.Now,
                Amount = -amount
            };
            Transactions.Add(transaction);
        }

        // Méthode pour générer un relevé de compte
        public string PrintStatement()
        {
            var statementPrinter = new StatementPrinter(Transactions);
            return statementPrinter.PrintStatement();
        }
    }
}
