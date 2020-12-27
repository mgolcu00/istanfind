using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using istanfind.Data;
using istanfind.Models;

namespace istanfind.Controllers
{
    public class HistoricalPlaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoricalPlaceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HistoricalPlace
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricalPlace.ToListAsync());
        }

        // GET: HistoricalPlace/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalPlace = await _context.HistoricalPlace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicalPlace == null)
            {
                return NotFound();
            }

            return View(historicalPlace);
        }

        // GET: HistoricalPlace/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricalPlace/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText")] HistoricalPlace historicalPlace)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historicalPlace);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicalPlace);
        }

        // GET: HistoricalPlace/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalPlace = await _context.HistoricalPlace.FindAsync(id);
            if (historicalPlace == null)
            {
                return NotFound();
            }
            return View(historicalPlace);
        }

        // POST: HistoricalPlace/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText")] HistoricalPlace historicalPlace)
        {
            if (id != historicalPlace.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicalPlace);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricalPlaceExists(historicalPlace.Id))
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
            return View(historicalPlace);
        }

        // GET: HistoricalPlace/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalPlace = await _context.HistoricalPlace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicalPlace == null)
            {
                return NotFound();
            }

            return View(historicalPlace);
        }

        // POST: HistoricalPlace/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historicalPlace = await _context.HistoricalPlace.FindAsync(id);
            _context.HistoricalPlace.Remove(historicalPlace);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricalPlaceExists(int id)
        {
            return _context.HistoricalPlace.Any(e => e.Id == id);
        }
    }
}
