using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DebtCalculatorWebApp.Models;

namespace DebtCalculatorWebApp.Controllers
{
    public class AutoLoansController : Controller
    {
        private readonly DebtCalculatorWebAppContext _context;

        public AutoLoansController(DebtCalculatorWebAppContext context)
        {
            _context = context;
        }

        // GET: AutoLoans
        public async Task<IActionResult> Index()
        {
            return View(await _context.AutoLoan.ToListAsync());
        }

        // GET: AutoLoans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoLoan = await _context.AutoLoan
                .FirstOrDefaultAsync(m => m.AutoLoanId == id);
            if (autoLoan == null)
            {
                return NotFound();
            }

            return View(autoLoan);
        }

        // GET: AutoLoans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AutoLoans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoLoanId,AutoLoanAmount,AutoLoanTime,AutoLoanApr,RecordDate")] AutoLoan autoLoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autoLoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autoLoan);
        }

        // GET: AutoLoans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoLoan = await _context.AutoLoan.FindAsync(id);
            if (autoLoan == null)
            {
                return NotFound();
            }
            return View(autoLoan);
        }

        // POST: AutoLoans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutoLoanId,AutoLoanAmount,AutoLoanTime,AutoLoanApr,RecordDate")] AutoLoan autoLoan)
        {
            if (id != autoLoan.AutoLoanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autoLoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoLoanExists(autoLoan.AutoLoanId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(autoLoan);
        }

        // GET: AutoLoans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoLoan = await _context.AutoLoan
                .FirstOrDefaultAsync(m => m.AutoLoanId == id);
            if (autoLoan == null)
            {
                return NotFound();
            }

            return View(autoLoan);
        }

        // POST: AutoLoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autoLoan = await _context.AutoLoan.FindAsync(id);
            _context.AutoLoan.Remove(autoLoan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoLoanExists(int id)
        {
            return _context.AutoLoan.Any(e => e.AutoLoanId == id);
        }
    }
}
