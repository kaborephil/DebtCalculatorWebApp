using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebtCalculatorWebApp.Models
{
    public class AutoLoan
    {
        public double AutoLoanAmount { get; set; }
        public int AutoLoanTime { get; set; }
        public double AutoLoanApr { get; set; }
    }
}
