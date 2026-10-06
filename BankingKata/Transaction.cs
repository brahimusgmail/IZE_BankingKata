using System;
using System.Collections.Generic;
using System.Text;

namespace BankingKata
{
    // Cette classe représente une transaction bancaire avec une date et un montant.
    public class Transaction
    {
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }
    }
}
