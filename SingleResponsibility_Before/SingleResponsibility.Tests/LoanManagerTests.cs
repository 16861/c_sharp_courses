using NUnit.Framework;
using SingleResponsibility_Before;

namespace SingleResponsibility.Tests
{
    [TestFixture]
    class LoanManagerTests
    {
        [Test]
        public void TestLoanManagerSuccess()
        {
            var loanManager = new LoanManager();

            Assert.IsTrue(loanManager.CreateLoan(new LoanData("+380999999999", 100, 10)).IsSuccess);
        }
        [Test]
        public void TestLoanManagerFailedAmount() {
            var loanManager = new LoanManager();

            Assert.IsFalse(loanManager.CreateLoan(new LoanData("+380999999999", 500, 10)).IsSuccess);
        }
        [Test]
        public void TestLoanManagerFailedDays() {
            var loanManager = new LoanManager();

            Assert.IsFalse(loanManager.CreateLoan(new LoanData("+380999999999", 100, 15)).IsSuccess);
        }
        [Test]
        public void TestLoanManagerFailedPhone() {
            var loanManager = new LoanManager();

            Assert.IsFalse(loanManager.CreateLoan(new LoanData("380999999999", 100, 15)).IsSuccess);
        }
        [Test]
        public void TestRiskManager() {
            var riskManager = new RiskManager();

            //test bad phones
            Assert.IsTrue(riskManager.CheckForBadPhones("+380111111111"));

            //test good phones
            Assert.IsFalse(riskManager.CheckForBadPhones("+380111111005"));
        }
        [Test]
        public void CalculatirManager() {
            var calculatorManager = new CalculatorManager();

            Assert.AreEqual(calculatorManager.CalculateLoan(200, 10), 260.92);
        }
    }
}
