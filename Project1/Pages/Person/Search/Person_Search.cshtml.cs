using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project1.Models;

namespace Project1.Pages.Person.Search
{
    public class Person_Search_Model : PageModel
    {
        [BindProperty] public Project1.Models.Person person {get; set;}
        [BindProperty] public uint ID {get; set;}

        private readonly AppDbContext _db;

        public Person_Search_Model(AppDbContext db)
        {
            _db = db;
        }

        public void OnPost()
        {
            person = _db.t_Person.Find(ID);
        }

        public IActionResult OnPostDelete()
        {
            Project1.Models.Person aux = _db.t_Person.Find(person.IdNumber);
            _db.t_Person.Remove(aux);
            _db.SaveChanges();

            return RedirectToPage("/Person/Search/Person_Search");
        }

        public void OnDelete()
        {

        }
    }
}