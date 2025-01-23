using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Properties.Data;

namespace WebApplication1.Controllers
{
    public class EmployeeListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeLists
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(await _context.EmployeeLists.GetPagedAsync(page, 10));
        }

        // GET: EmployeeLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeList = await _context.EmployeeLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeList == null)
            {
                return NotFound();
            }

            return View(employeeList);
        }

        // GET: EmployeeLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] EmployeeList employeeList)
        {
            if (ModelState.IsValid)
            {
                _context.EmployeeLists.Add(employeeList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeList);
        }

        // GET: EmployeeLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeList = await _context.EmployeeLists.FindAsync(id);
            if (employeeList == null)
            {
                return NotFound();
            }
            return View(employeeList);
        }

        // POST: EmployeeLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] EmployeeList employeeList)
        {
            if (id != employeeList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeListExists(employeeList.Id))
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
            return View(employeeList);
        }

        // GET: EmployeeLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeList = await _context.EmployeeLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeList == null)
            {
                return NotFound();
            }

            return View(employeeList);
        }

        // POST: EmployeeLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeList = await _context.EmployeeLists.FindAsync(id);
            if (employeeList != null)
            {
                _context.EmployeeLists.Remove(employeeList);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeListExists(int id)
        {
            return _context.EmployeeLists.Any(e => e.Id == id);
        }
    }
}
