using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebtCalculatorWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DebtCalculatorWebApp.Controllers
{
    [Authorize]
    public class LoginCalculatorController : Controller
    {
        private readonly DebtCalculatorWebAppContext _db;

        
        public LoginCalculatorController(DebtCalculatorWebAppContext db)
        {
            _db = db;
        }
        
        public IActionResult LoginResults()
        {
            
            return View(_db);
        }
    }
}