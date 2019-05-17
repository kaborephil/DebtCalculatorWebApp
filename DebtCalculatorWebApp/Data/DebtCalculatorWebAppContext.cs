using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DebtCalculatorWebApp.Models;

namespace DebtCalculatorWebApp.Models
{
    public class DebtCalculatorWebAppContext : DbContext
    {
        public DebtCalculatorWebAppContext (DbContextOptions<DebtCalculatorWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<DebtCalculatorWebApp.Models.AutoLoan> AutoLoan { get; set; }

        public DbSet<DebtCalculatorWebApp.Models.CreditCardLoan> CreditCardLoan { get; set; }

        public DbSet<DebtCalculatorWebApp.Models.Mortgage> Mortgage { get; set; }
    }
}
