﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DebtCalculatorWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}