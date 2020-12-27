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
    public class FunPlaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FunPlaceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FunPlace
        public async Task<IActionResult> Index()
        {
            return View(await _context.FunPlace.ToListAsync());
        }

        // GET: FunPlace/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funPlace = await _context.FunPlace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funPlace == null)
            {
                return NotFound();
            }

            return View(funPlace);
        }

        // GET: FunPlace/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FunPlace/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText")] FunPlace funPlace)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funPlace);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funPlace);
        }

        // GET: FunPlace/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funPlace = await _context.FunPlace.FindAsync(id);
            if (funPlace == null)
            {
                return NotFound();
            }
            return View(funPlace);
        }

        // POST: FunPlace/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText")] FunPlace funPlace)
        {
            if (id != funPlace.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funPlace);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FunPlaceExists(funPlace.Id))
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
            return View(funPlace);
        }

        // GET: FunPlace/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funPlace = await _context.FunPlace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funPlace == null)
            {
                return NotFound();
            }

            return View(funPlace);
        }

        // POST: FunPlace/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funPlace = await _context.FunPlace.FindAsync(id);
            _context.FunPlace.Remove(funPlace);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FunPlaceExists(int id)
        {
            return _context.FunPlace.Any(e => e.Id == id);
        }
    }
}
