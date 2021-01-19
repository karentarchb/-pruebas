using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project1.Models;


namespace Project1.Pages.Person
{
    public class Person_Create_Model : PageModel
    {
        [BindProperty] public Project1.Models.Person person {get; set;}

        private readonly AppDbContext _db;

        public Person_Create_Model(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult OnPost()
        {
            _db.t_Person.Add(person);
            _db.SaveChanges();

            return RedirectToPage("/Person/Person_Create_Successful");
        }
    }
}