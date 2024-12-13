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
    public class DeleteModel : PageModel
    {
        private readonly PlayerBank.Models.AppDbContext _context;

        public DeleteModel(PlayerBank.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Athlete Athlete { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete = await _context.Athletes.FirstOrDefaultAsync(m => m.AthleteID == id);

            if (athlete is not null)
            {
                Athlete = athlete;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete = await _context.Athletes.FindAsync(id);
            if (athlete != null)
            {
                Athlete = athlete;
                _context.Athletes.Remove(Athlete);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
