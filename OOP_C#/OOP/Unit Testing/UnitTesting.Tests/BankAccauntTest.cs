using NUnit.Framework;

namespace UnitTesting.Tests
{
    [TestFixture]

    public class BankAccauntTest
    {
        private BankAccaunt bankAccaunt;

        [SetUp]
        public void CreateBankAccaunt()
        {
            bankAccaunt = new BankAccaunt(100);
        }
        [TearDown]
        public void RemoveBankAccaunt()
        {
            bankAccaunt = null;
        }

        [Test]
        public void TestNewBankAccaunt()
        {
            //  var bankAccaunt = new BankAccaunt(100m);

            Assert.That(bankAccaunt.Balance, Is.EqualTo(100m),"Create a new Bank Accaunt");
        }
        [Test]
        public void TestNewBankAccauntWithNegativeBalance()
        {
            Assert.That(() => new BankAccaunt(-100m),
                Throws.ArgumentException.With.Message.EqualTo("Balance can not be negative."));
        }
        [Test]
        public void TestDeposit()
        {
            bankAccaunt.Deposit(100m);
            Assert.That(bankAccaunt.Balance, Is.EqualTo(200m));
        }
        [Test]
        public void TestDepositWithNegativeSum()
        {
            Assert.That(() => bankAccaunt.Deposit(-50m),
                Throws.ArgumentException);
        }
        [Test]
        public void TestWithdraw()
        {
            decimal balance = bankAccaunt.Withdraw(34m);
            Assert.That(bankAccaunt.Balance, Is.EqualTo(balance));
        }
        [Test]
        public void TestWithdrawMoreThenBalance()
        {
            Assert.That(() => bankAccaunt.Withdraw(500m),
                Throws.ArgumentException.With.Message
                .EqualTo("Balance can not be negative."));
        }

    }
}
