using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CALLОМОЙСЬКИЙ.Data;
using CALLОМОЙСЬКИЙ.Models.Domain;

namespace CALLОМОЙСЬКИЙ.Controllers
{
    public class CallsController : Controller
    {
        private readonly ProjectContext _context;

        public CallsController(ProjectContext context)
        {
            _context = context;
        }

        // GET: Calls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Calls.ToListAsync());
        }

        // GET: Calls/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calls = await _context.Calls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calls == null)
            {
                return NotFound();
            }

            return View(calls);
        }

        // GET: Calls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Calls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CallerUserId,ReceiverUserId,StartTime,EndTime")] Calls calls)
        {
            if (ModelState.IsValid)
            {
                calls.Id = Guid.NewGuid();
                _context.Add(calls);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calls);
        }

        // GET: Calls/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calls = await _context.Calls.FindAsync(id);
            if (calls == null)
            {
                return NotFound();
            }
            return View(calls);
        }

        // POST: Calls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CallerUserId,ReceiverUserId,StartTime,EndTime")] Calls calls)
        {
            if (id != calls.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calls);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CallsExists(calls.Id))
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
            return View(calls);
        }

        // GET: Calls/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calls = await _context.Calls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calls == null)
            {
                return NotFound();
            }

            return View(calls);
        }

        // POST: Calls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var calls = await _context.Calls.FindAsync(id);
            if (calls != null)
            {
                _context.Calls.Remove(calls);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CallsExists(Guid id)
        {
            return _context.Calls.Any(e => e.Id == id);
        }
    }
}
