using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebtCalculatorWebApp.Models
{
    public class Mortgage
    {
        public int MortgageId { get; set; }
        public double MortgageAmount { get; set; }
        public int MortgageTime { get; set; }
        public double MortgageApr { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
