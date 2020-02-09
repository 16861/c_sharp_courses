using System;

namespace SingleResponsibility_Before {
    public class CalculatorManager {
        public const double Commission = 0.2;
        public const double DailyPercent = 1.01;

        public double CalculateLoan(double amount, int days) {
            return Math.Round(amount * (Math.Pow(DailyPercent, days) + Commission), 2);
        }
    }
}