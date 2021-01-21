using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.SqlServer;
using Project1.Models;

namespace Project1.Pages.Roulette
{
    public class Create_Result_Model : PageModel
    {
        private readonly AppDbContext _db;
        public Project1.Models.Casino.Result result {get; set;}
        public Create_Result_Model(AppDbContext db)
        {
            _db = db;
        }

        public async Task OnGetAsync()
        {
           result = await _db.t_Result.FindAsync(1);

           if(result == null)
           {
               for( int i = 1; i<=36;i++)
               {
                  string s = ((i-1) % 2) == 0 ? "Rojo" : "Negro";

                   Project1.Models.Casino.Result aux = 
                    new Models.Casino.Result { number = i-1, color = s};

                    await _db.t_Result.AddAsync(aux);
               }
               
                await _db.SaveChangesAsync();
           }
        }
    }
}