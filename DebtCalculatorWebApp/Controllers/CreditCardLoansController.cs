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
    public class CreditCardLoansController : Controller
    {
        private readonly DebtCalculatorWebAppContext _context;

        public CreditCardLoansController(DebtCalculatorWebAppContext context)
        {
            _context = context;
        }

        // GET: CreditCardLoans
        public async Task<IActionResult> Index()
        {
            return View(await _context.CreditCardLoan.ToListAsync());
        }

        // GET: CreditCardLoans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditCardLoan = await _context.CreditCardLoan
                .FirstOrDefaultAsync(m => m.CreditCardLoanId == id);
            if (creditCardLoan == null)
            {
                return NotFound();
            }

            return View(creditCardLoan);
        }

        // GET: CreditCardLoans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CreditCardLoans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CreditCardLoanId,CreditCardLoanAmount,CreditCardLoanTime,CreditcardLoanApr,RecordDate")] CreditCardLoan creditCardLoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(creditCardLoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(creditCardLoan);
        }

        // GET: CreditCardLoans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditCardLoan = await _context.CreditCardLoan.FindAsync(id);
            if (creditCardLoan == null)
            {
                return NotFound();
            }
            return View(creditCardLoan);
        }

        // POST: CreditCardLoans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CreditCardLoanId,CreditCardLoanAmount,CreditCardLoanTime,CreditcardLoanApr,RecordDate")] CreditCardLoan creditCardLoan)
        {
            if (id != creditCardLoan.CreditCardLoanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(creditCardLoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreditCardLoanExists(creditCardLoan.CreditCardLoanId))
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
            return View(creditCardLoan);
        }

        // GET: CreditCardLoans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditCardLoan = await _context.CreditCardLoan
                .FirstOrDefaultAsync(m => m.CreditCardLoanId == id);
            if (creditCardLoan == null)
            {
                return NotFound();
            }

            return View(creditCardLoan);
        }

        // POST: CreditCardLoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var creditCardLoan = await _context.CreditCardLoan.FindAsync(id);
            _context.CreditCardLoan.Remove(creditCardLoan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreditCardLoanExists(int id)
        {
            return _context.CreditCardLoan.Any(e => e.CreditCardLoanId == id);
        }
    }
}
