using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebtCalculatorWebApp.Models;

namespace DebtCalculatorWebApp.ViewModels
{
    public class CalculatorCreateViewModels
    {
        public AutoLoan AutoLoan { get; set; }
        public CreditCardLoan CreditCardLoan { get; set; }
        public Mortgage Mortgage { get; set; }


        public double MonthyPayment(double Amount, int Time, double APR)
        {

            var YearlyInterest = (Amount * (APR / 100));

            var TotalInterest = YearlyInterest * Time;

            double MonthlyPay = (Amount + TotalInterest) / (Time * 12);

            return MonthlyPay;
        }
    }
}
