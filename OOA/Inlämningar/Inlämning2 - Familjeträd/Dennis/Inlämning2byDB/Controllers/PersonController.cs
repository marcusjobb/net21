using Inlämning2byDB.Models;
using Inlämning2byDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inlämning2byDB.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonService _persons;
        public PersonController(PersonService personService)
        {
            _persons = personService;
        }

        public IActionResult Index()
        {
            var allPersons = _persons.GetAllPersons();
            return View(allPersons);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person obj)
        {
            if (ModelState.IsValid)
            {
                _persons.CreatePerson(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // Get-Delete
        public IActionResult Delete(int id)
        {
            var person = _persons.GetPerson(id);
            if (person is null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var obj = _persons.GetPerson(id);
            if (obj == null)
            {
                return NotFound();
            }
            _persons.DeletePerson(obj);
            return RedirectToAction("Index");
        }

        // Get-Edit
        public IActionResult Edit(int id)
        {
            var person = _persons.GetPerson(id);
            if (person is null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST-Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Person obj)
        {
            if (ModelState.IsValid)
            {
                _persons.UpdatePerson(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // Get-View
        public IActionResult View(int id)
        {
            var model = new ViewPerson();
            model.Person = _persons.GetPerson(id);
            if (model.Person is null)
            {
                return NotFound();
            }
            model.Children = _persons.GetChildrens(id);
            return View(model);
        }
    }
}
