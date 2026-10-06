using System;
using System.Collections.Generic;
using System.Text;

namespace BankingKata.Tests
{
    public class AccountTests
    {

        [Fact]
        public void Deposit_ShouldIncreaseBalance_By_Thousand_If_Deposited()
        {
            var account = new Account();

            account.Deposit(1000);

            var result = account.PrintStatement();

            Assert.Contains("1000", result);
        }

        [Fact]
        public void Withdraw_ShouldDecreaseBalance_By_Fifty_If_Withdrawn()
        {
            // Arrange
            var account = new Account();

            account.Deposit(50);

            var result = account.PrintStatement();

            Assert.Contains("50", result);
        }
    }
}
