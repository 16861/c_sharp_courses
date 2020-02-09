using System.Text.RegularExpressions;

namespace SingleResponsibility_Before {
    class ValidatorManager {

        private const int minAmount = 200;
        private const int minDays = 14;

        private bool IsPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"\+\d{12}");
        }
        public bool ValidateLoan(string phoneNumber, double amount, int days) {
            return !IsPhoneNumber(phoneNumber) || amount < 0 || amount > minAmount || days < 0 || days > minDays;
        }
    }
}