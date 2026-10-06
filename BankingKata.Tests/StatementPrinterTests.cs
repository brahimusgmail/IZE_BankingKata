using System;
using System.Collections.Generic;
using Xunit;
using BankingKata;
using System.Text;

namespace BankingKata.Tests
{
    public class StatementPrinterTests
    {
        [Fact]
        public void PrintStatement_ReturnsExactExpectedString()
        {

            var transactions = new List<Transaction>
                {
                    new Transaction { Date = new DateTime(2023,1,1), Amount = 1000m },
                    new Transaction { Date = new DateTime(2023,1,2), Amount = -200m }
                };

            var printer = new StatementPrinter(transactions);
            var output = printer.PrintStatement();

            var expected = new StringBuilder();
            expected.AppendLine("Date | Amount | Balance");
            // les lignes suivantes sont les transactions dans l'ordre inverse de leur date
            expected.AppendLine("02/01/2023 | -200,00 | 800,00");
            expected.AppendLine("01/01/2023 | 1000,00 | 1000,00");

            Assert.Equal(expected.ToString(), output);

        }

        [Fact]
        public void PrintStatement_ReturnsHeaderOnly_WhenNoTransactions()
        {
            var transactions = new List<Transaction>();

            var printer = new StatementPrinter(transactions);
            var output = printer.PrintStatement();

            var expected = new StringBuilder();
            expected.AppendLine("Date | Amount | Balance");

            Assert.Equal(expected.ToString(), output);
        }
    }
}
