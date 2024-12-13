using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlayerBank.Models;

namespace PlayerBank.Pages_Athletes
{
    public class IndexModel : PageModel
    {
        private readonly PlayerBank.Models.AppDbContext _context;

        public IndexModel(PlayerBank.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Athlete> Athlete { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Athlete = await _context.Athletes
                .Include(a => a.College).ToListAsync();
        }
    }
}
