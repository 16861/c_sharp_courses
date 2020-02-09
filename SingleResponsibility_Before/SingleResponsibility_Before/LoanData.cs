namespace SingleResponsibility_Before {
    public class LoanData {
        public string PhoneNumber { get; }
        public int Days { get; }
        public double Amount {get; }

        public LoanData(string phone, double amount, int days)
        {
            PhoneNumber = phone;
            Amount = amount;
            Days = days;
        }
        
    }

}