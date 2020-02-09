namespace SingleResponsibility_Before
{
    public class CreateLoanResult
    {
        public bool IsSuccess { get; private set; }
        public double AmountToReturn { get; }

        private CreateLoanResult(bool isSuccess, double amountToReturn)
        {
            IsSuccess = isSuccess;
            AmountToReturn = amountToReturn;
        }

        public static CreateLoanResult Failed()
        {
            return new CreateLoanResult(false, 0);
        }

        public static CreateLoanResult Success(double amountToReturn)
        {
            return new CreateLoanResult(true, amountToReturn);
        }

    }
}