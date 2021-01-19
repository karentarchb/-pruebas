using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project1.Models;

namespace Project1.Pages.Person.Update
{
    public class Person_Update_Model : PageModel
    {
        [BindProperty] public Project1.Models.Person person {get; set;}
        [BindProperty] public uint ID {get; set;}
        private readonly AppDbContext _db;
        public Person_Update_Model(AppDbContext db)
        {
            _db = db;
        }

        public void OnGet(uint ID)
        {
            person = _db.t_Person.Find(ID);
        }

        public IActionResult OnPost()
        {
            Project1.Models.Person aux = _db.t_Person.Find(person.IdNumber);
            aux.name = person.name;
            aux.lastName = person.lastName;
            aux.age = person.age;

            _db.SaveChanges();

            return RedirectToPage("/Person/Search/Person_Search");
        }
    }
}