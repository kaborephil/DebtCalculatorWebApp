using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebtCalculatorWebApp.Models;
using DebtCalculatorWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DebtCalculatorWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Results(AutoLoan autoLoan, CreditCardLoan creditCardLoan, Mortgage mortgage)
        {
            CalculatorCreateViewModels Vm = new CalculatorCreateViewModels()
            {
                AutoLoan = autoLoan,
                CreditCardLoan = creditCardLoan,
                Mortgage = mortgage
            };

            return View(Vm);
        }
    }
}