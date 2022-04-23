﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Conciertos1.Data;
using Conciertos1.Data.Entities;

namespace Conciertos1.Controllers
{
    public class EntrancesController : Controller
    {
        private readonly DataContext _context;

        public EntrancesController(DataContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entrances.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrance = await _context.Entrances
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entrance == null)
            {
                return NotFound();
            }

            return View(entrance);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] Entrance entrance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entrance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entrance);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrance = await _context.Entrances.FindAsync(id);
            if (entrance == null)
            {
                return NotFound();
            }
            return View(entrance);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description")] Entrance entrance)
        {
            if (id != entrance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entrance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntranceExists(entrance.Id))
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
            return View(entrance);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrance = await _context.Entrances
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entrance == null)
            {
                return NotFound();
            }

            return View(entrance);
        }

      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entrance = await _context.Entrances.FindAsync(id);
            _context.Entrances.Remove(entrance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntranceExists(int id)
        {
            return _context.Entrances.Any(e => e.Id == id);
        }
    }
}
