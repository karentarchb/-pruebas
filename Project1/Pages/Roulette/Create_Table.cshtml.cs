using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Project1.Models;

namespace Project1.Pages.Roulette
{
    public class Create_Roulette_Model : PageModel
    {
        public Project1.Models.Casino.Roulette roulette {get; set;}

        private readonly AppDbContext _db;

        public Create_Roulette_Model(AppDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            roulette = new Project1.Models.Casino.Roulette();
            _db.t_Roulette.Add(roulette);

            _db.SaveChanges();

            int i = _db.t_Roulette.ToList<Project1.Models.Casino.Roulette>().Count;

            roulette = _db.t_Roulette.Find(i);
        }

    }
}