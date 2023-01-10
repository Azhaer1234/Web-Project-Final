using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_Project_Final.Models;

namespace Web_Project_Final.Controllers
{
    public class ContectDataModelsController : Controller
    {
        private readonly SocialDBContext _context;

        public ContectDataModelsController(SocialDBContext context)
        {
            _context = context;
        }

        // GET: ContectDataModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.ContectDataModels.ToListAsync());
        }

        // GET: ContectDataModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ContectDataModels == null)
            {
                return NotFound();
            }

            var contectDataModel = await _context.ContectDataModels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contectDataModel == null)
            {
                return NotFound();
            }

            return View(contectDataModel);
        }

        // GET: ContectDataModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContectDataModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,Email,Phnone")] ContectDataModel contectDataModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contectDataModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contectDataModel);
        }

        // GET: ContectDataModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContectDataModels == null)
            {
                return NotFound();
            }

            var contectDataModel = await _context.ContectDataModels.FindAsync(id);
            if (contectDataModel == null)
            {
                return NotFound();
            }
            return View(contectDataModel);
        }

        // POST: ContectDataModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,Email,Phnone")] ContectDataModel contectDataModel)
        {
            if (id != contectDataModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contectDataModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContectDataModelExists(contectDataModel.ID))
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
            return View(contectDataModel);
        }

        // GET: ContectDataModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContectDataModels == null)
            {
                return NotFound();
            }

            var contectDataModel = await _context.ContectDataModels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contectDataModel == null)
            {
                return NotFound();
            }

            return View(contectDataModel);
        }

        // POST: ContectDataModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContectDataModels == null)
            {
                return Problem("Entity set 'SocialDBContext.ContectDataModels'  is null.");
            }
            var contectDataModel = await _context.ContectDataModels.FindAsync(id);
            if (contectDataModel != null)
            {
                _context.ContectDataModels.Remove(contectDataModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContectDataModelExists(int id)
        {
          return _context.ContectDataModels.Any(e => e.ID == id);
        }
    }
}
