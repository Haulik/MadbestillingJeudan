using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMadMenu.Data;
using MvcMadMenu.Models;

namespace Madbestilling.Controllers
{
    public class MadMenuController : Controller
    {
        private readonly MvcMadMenuContext _context;

        public MadMenuController(MvcMadMenuContext context)
        {
            _context = context;
        }

        // GET: MadMenu
        public async Task<IActionResult> Index()
        {

            return View(await _context.Madmenu.ToListAsync());
        }

        // GET: MadMenu/Bestilling
        public async Task<IActionResult> Bestilling()
        {

            return View(await _context.Madmenu.ToListAsync());
        }

        // GET: MadMenu/MineBestillinger
        public async Task<IActionResult> MineBestillinger()
        {

            return View(await _context.Madmenu.ToListAsync());
        }

        // GET: MadMenu/HovedMenu
        public async Task<IActionResult> HovedMenu()
        {

            return View(await _context.Madmenu.ToListAsync());
        }

        // GET: MadMenu/Info
        public IActionResult Info()
        {

            return View();
        }

        // GET: MadMenu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var madMenu = await _context.Madmenu
                .FirstOrDefaultAsync(m => m.Menuid == id);
            if (madMenu == null)
            {
                return NotFound();
            }

            return View(madMenu);
        }

        // GET: MadMenu/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MadMenu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Menu,Med_Hjem_Køkken,Dato,Uge,UgeNavn,MenuStatus")] MadMenu madMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(madMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(madMenu);
        }

        // GET: MadMenu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var madMenu = await _context.Madmenu.FindAsync(id);
            if (madMenu == null)
            {
                return NotFound();
            }
            return View(madMenu);
        }

        // POST: MadMenu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Menu,Med_Hjem_Køkken,Dato,Uge,UgeNavn,MenuStatus")] MadMenu madMenu)
        {
            if (id != madMenu.Menuid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(madMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MadMenuExists(madMenu.Menuid))
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
            return View(madMenu);
        }

        // GET: MadMenu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var madMenu = await _context.Madmenu
                .FirstOrDefaultAsync(m => m.Menuid == id);
            if (madMenu == null)
            {
                return NotFound();
            }

            return View(madMenu);
        }

        // POST: MadMenu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var madMenu = await _context.Madmenu.FindAsync(id);
            _context.Madmenu.Remove(madMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MadMenuExists(int id)
        {
            return _context.Madmenu.Any(e => e.Menuid == id);
        }
    }
}
