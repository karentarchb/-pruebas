using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

using Project1.Models;

namespace Project1.Pages.Roulette
{
    public class Create_Bet_Model : PageModel
    {
        private readonly AppDbContext _db;

        public List<Project1.Models.Casino.Roulette> roulettes {get; set;}
        public SelectList optionsRoulette {get;set;}
        public Project1.Models.Casino.Bet bet {get; set;}
        public List<Project1.Models.Casino.Result> results {get; set;}

        public Create_Bet_Model (AppDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            roulettes = _db.t_Roulette.ToList();
            results = _db.t_Result.ToList();

            optionsRoulette = new SelectList(roulettes, nameof(roulettes.rouletteID));

        }

    }
}