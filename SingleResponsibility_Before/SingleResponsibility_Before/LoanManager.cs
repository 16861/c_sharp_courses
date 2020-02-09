namespace SingleResponsibility_Before
{
    public class LoanManager
    {
        private RiskManager riskManager = new RiskManager();
        private SaveUserManager saveUserManager = new SaveUserManager();
        private CalculatorManager calculatorManager = new CalculatorManager();
        private ValidatorManager validatorManager = new ValidatorManager();

        public LoanManager()
        {
        }

        public CreateLoanResult CreateLoan(LoanData data)
        {
            Logger.LogLine($"Processing loan request for user {data.PhoneNumber}");

            if (validatorManager.ValidateLoan(data.PhoneNumber, data.Amount, data.Days))
            {
                Logger.LogLine($"Cannot create loan, validation failed.");
                return CreateLoanResult.Failed();
            }

            saveUserManager.SaveUser(new User(data.PhoneNumber));

            if (riskManager.CheckForBadPhones(data.PhoneNumber))
            {
                Logger.LogLine($"Cannot create loan, user phone is in BadPhone Collection");
                return CreateLoanResult.Failed();
            }

            return CreateLoanResult.Success(calculatorManager.CalculateLoan(data.Amount, data.Days));
        }
    }
}
