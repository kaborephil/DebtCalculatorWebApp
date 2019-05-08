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
    }
}
