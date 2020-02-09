using System;

namespace SingleResponsibility_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            var loanManager = new LoanManager();

            var result = loanManager.CreateLoan(new LoanData("+380999999999", 150, 10));

            if (result.IsSuccess)
            {
                Console.WriteLine($"Loan created. Amount to return: {result.AmountToReturn} UAH");
            }
            else
            {
                Console.WriteLine($"Loan has not been created");
            }
        }
    }
}
