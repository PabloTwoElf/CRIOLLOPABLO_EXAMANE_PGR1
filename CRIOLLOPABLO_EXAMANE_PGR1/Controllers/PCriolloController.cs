using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRIOLLOPABLO_EXAMANE_PGR1.Data;
using CRIOLLOPABLO_EXAMANE_PGR1.Models;

namespace CRIOLLOPABLO_EXAMANE_PGR1.Controllers
{
    public class PCriolloController : Controller
    {
        private readonly CRIOLLOPABLO_EXAMANE_PGR1Context _context;

        public PCriolloController(CRIOLLOPABLO_EXAMANE_PGR1Context context)
        {
            _context = context;
        }

        // GET: PCriollo
        public async Task<IActionResult> Index()
        {
            return View(await _context.PCriollo.ToListAsync());
        }

        // GET: PCriollo/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCriollo = await _context.PCriollo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pCriollo == null)
            {
                return NotFound();
            }

            return View(pCriollo);
        }

        // GET: PCriollo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PCriollo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Altura,Discapacidad,Fecha,IdCelular")] PCriollo pCriollo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pCriollo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pCriollo);
        }

        // GET: PCriollo/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCriollo = await _context.PCriollo.FindAsync(id);
            if (pCriollo == null)
            {
                return NotFound();
            }
            return View(pCriollo);
        }

        // POST: PCriollo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Nombre,Altura,Discapacidad,Fecha,IdCelular")] PCriollo pCriollo)
        {
            if (id != pCriollo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pCriollo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PCriolloExists(pCriollo.Id))
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
            return View(pCriollo);
        }

        // GET: PCriollo/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCriollo = await _context.PCriollo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pCriollo == null)
            {
                return NotFound();
            }

            return View(pCriollo);
        }

        // POST: PCriollo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pCriollo = await _context.PCriollo.FindAsync(id);
            if (pCriollo != null)
            {
                _context.PCriollo.Remove(pCriollo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PCriolloExists(string id)
        {
            return _context.PCriollo.Any(e => e.Id == id);
        }
    }
}
