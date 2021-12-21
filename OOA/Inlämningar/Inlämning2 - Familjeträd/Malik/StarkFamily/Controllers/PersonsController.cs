using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StarkFamily.Data;
using StarkFamily.Models;

namespace StarkFamily.Controllers
{
    public class PersonsController : Controller
    {
        private readonly FamilyContext _context;

        public PersonsController(FamilyContext context)
        {
            _context = context;
        }

       
        // GET: Persons
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            var persons = from s in _context.Personos select s;
            var fathers = _context.Personos.Include(p => p.Father);

            //ViewData["persons"] = await persons.AsNoTracking().ToListAsync();


            dynamic mymodel = new ExpandoObject();

            //var fathers = _context.Personos.Include(p => p.Father);
            //var persons = from s in _context.Personos select s;

            switch (sortOrder)
            {
                case "name_desc":
                    persons = persons.OrderByDescending(s => s.FirstName);
                    break;
                case "Date":
                    persons = persons.OrderBy(s => s.BirthDate);
                    break;
                case "date_desc":
                    persons = persons.OrderByDescending(s => s.BirthDate);
                    break;
                default:
                    persons = persons.OrderBy(s => s.FirstName);
                    break;
            }


            //return View(await persons.AsNoTracking().ToListAsync());
            return View(await fathers.ToListAsync());





        }

        // GET: Father
        

        // GET: Persons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Personos
                .Include(p => p.Father)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            var childe = await _context.Personos.Where(p => p.FatherId == id.Value).ToListAsync();

            if (childe == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: Persons/Create
        public IActionResult Create()
        {
            ViewData["FatherId"] = new SelectList(_context.Personos, "Id", "FirstName");
            return View();
        }

        // POST: Persons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,BirthDate,DeathDate,FatherId")] Person person)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _context.Add(person);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }

            ViewData["FatherId"] = new SelectList(_context.Personos, "FatherId", "FatherId", person.FirstName);
            return View(person);
        }

        // GET: Persons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Personos.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            ViewData["FatherId"] = new SelectList(_context.Personos, "Id", "FirstName");
            return View(person);
        }

        // POST: Persons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personToUpdate = await _context.Personos.FirstOrDefaultAsync(s => s.Id == id);
            if (await TryUpdateModelAsync<Person>(
                    personToUpdate,
                    "",
                s => s.FirstName, s => s.LastName, s => s.BirthDate, s => s.DeathDate, s => s.FatherId))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
                                            "Try again, and if the problem persists, " +
                                            "see your system administrator.");
                }
            }
            ViewData["FatherId"] = new SelectList(_context.Personos, "Id", "Id");
            return View(personToUpdate);
        }

        // GET: Persons/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Personos
                .AsNoTracking()
                .Include(p => p.Father)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(person);
        }

        // POST: Persons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Personos.FindAsync(id);
            if (person == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.Personos.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool PersonExists(int id)
        {
            return _context.Personos.Any(e => e.Id == id);
        }
    }
}
