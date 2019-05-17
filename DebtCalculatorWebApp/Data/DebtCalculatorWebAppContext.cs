using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DebtCalculatorWebApp.Models
{
    public class DebtCalculatorWebAppContext : DbContext
    {
        public DebtCalculatorWebAppContext (DbContextOptions<DebtCalculatorWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<DebtCalculatorWebApp.Models.AutoLoan> AutoLoan { get; set; }
    }
}
