﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebtCalculatorWebApp.Models
{
    public class CreditCardLoan
    {
        public int CreditCardLoanId { get; set; }
        public double CreditCardLoanAmount { get; set; }
        public int CreditCardLoanTime { get; set; }
        public double CreditcardLoanApr { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
