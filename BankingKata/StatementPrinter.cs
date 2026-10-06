using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingKata
{
    // Cette classe est responsable de l'impression du relevé de compte à partir d'une liste de transactions.
    public class StatementPrinter
    {
        // liste des transactions à imprimer dans le relevé
        private List<Transaction> _transactions;

        // Constructeur qui prend une liste de transactions en paramètre
        public StatementPrinter(List<Transaction> transactions)
        {
            _transactions = transactions;
        }

        // Méthode pour générer le relevé de compte sous forme de chaîne de caractères triée par date décroissante, avec le solde calculé pour chaque transaction
        public string PrintStatement()
        {
            // calculer le solde pour chaque transaction et stocker les résultats dans une liste de tuples
            var rows = new List<(DateTime Date, decimal Amount, decimal Balance)>();
            decimal balance = 0m;
            foreach (var transaction in _transactions)
            {
                balance += transaction.Amount;
                rows.Add((transaction.Date, transaction.Amount, balance));
            }

            // Construire la chaîne de caractères représentant l'état du compte
            StringBuilder statement = new StringBuilder();
            statement.AppendLine("Date | Amount | Balance");

            // Imprimer les transactions dans l'ordre inverse (de la plus récente à la plus ancienne)
            foreach (var row in rows.OrderByDescending(r => r.Date))
            {
                statement.AppendLine($"{row.Date.ToShortDateString()} | {row.Amount:F2} | {row.Balance:F2}");
            }

            return statement.ToString();
        }
    }
}
