using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Genealogi.Data;
using Genealogi.Models;
using Genealogi.ViewModels;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Genealogi.Controllers
{
    public class PeopleController : Controller
    {
        private readonly GenealogiDbContext _context;

        public PeopleController(GenealogiDbContext context)
        {
            _context = context;

            Helpers.LoadPeople.Load(_context);
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            var genealogiDbContext = _context.People.Include(p => p.Father).Include(p => p.Mother);
            return View(await genealogiDbContext.ToListAsync());
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People
                .Include(p => p.Father)
                .Include(p => p.Mother)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        public async Task<JsonResult> GetDetails()
        {

            var people = _context.People.ToList();

            if (people == null)
            {
                return Json("Not Found", new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles });
            }

            return Json(people, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles });
        }


        // GET: People/Create
        public IActionResult Create()
        {
            ViewData["FatherId"] = new SelectList(_context.People, "Id", "Name");
            ViewData["MotherId"] = new SelectList(_context.People, "Id", "Name");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LastName,BirthDate,DeathDate,BirthPlace,DeathPlace,MotherId,FatherId,Image")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FatherId"] = new SelectList(_context.People, "Id", "Id", person.FatherId);
            ViewData["MotherId"] = new SelectList(_context.People, "Id", "Id", person.MotherId);
            return View(person);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var person = await _context.People.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            EditViewModel model = new(_context.People.Where(q => q.Id != id).ToList(), person);


            //ViewData["FatherId"] = new SelectList(_context.People, "Id", "Name", person.FatherId);
            //ViewData["MotherId"] = new SelectList(_context.People, "Id", "Name", person.MotherId);

            

            return View(model);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Person.Id,Person.Name,Person.LastName,Person.BirthDate,Person.DeathDate,Person.BirthPlace,Person.DeathPlace,Person.MotherId,Person.FatherId,Person.Image")] EditViewModel model)
        {
            var person = await _context.People
                .Include(p => p.Father)
                .Include(p => p.Mother)
                .FirstOrDefaultAsync(m => m.Id == id);
            /*
            if (id != model.Person.Id)
            {
                return View("Error");
            }
            */
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model.Person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(model.Person.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tree), new { id = model.Person.Id});
            }
            //ViewData["FatherId"] = new SelectList(_context.People, "Id", "Id", model.Person.FatherId);
            //ViewData["MotherId"] = new SelectList(_context.People, "Id", "Id", model.Person.MotherId);
            return View(new EditViewModel(_context.People.ToList(), person));
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People
                .Include(p => p.Father)
                .Include(p => p.Mother)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.People
                .FirstOrDefaultAsync(m => m.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            var kids = _context.People
                .Include(p => p.Father)
                .Include(p => p.Mother)
                .Where(m => m.FatherId == person.Id || m.MotherId == person.Id).ToList();

            kids.ForEach(k =>
            {
                if (k.MotherId == person.Id)
                    k.MotherId = null;
                else
                    k.FatherId = null;
            });


            _context.People.Remove(person);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.People.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Tree(int? id)
        {
            var person = await _context.People
                .Include(p => p.Father)
                .Include(p => p.Mother)
                .FirstOrDefaultAsync(m => m.Id == id);

            if(person == null)
            {
                person = await _context.People
                .Include(p => p.Father)
                .Include(p => p.Mother)
                .FirstOrDefaultAsync(m => m.Id <= 1000);
            }

            if (person is not null)
            {
                IEnumerable<Person> siblings = _context.People.Where(q => q.MotherId == person.MotherId || q.FatherId == person.FatherId);
                IEnumerable<Person> kids = _context.People.Where(q => q.MotherId == person.Id || q.FatherId == person.Id).ToList();

                FamilyViewModel family = new(person, siblings, kids);

                return View(family);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
