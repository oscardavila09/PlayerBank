using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlayerBank.Models;

namespace PlayerBank.Pages_Athletes
{
    public class EditModel : PageModel
    {
        private readonly PlayerBank.Models.AppDbContext _context;

        public EditModel(PlayerBank.Models.AppDbContext context)
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

            var athlete =  await _context.Athletes.FirstOrDefaultAsync(m => m.AthleteID == id);
            if (athlete == null)
            {
                return NotFound();
            }
            Athlete = athlete;
           ViewData["CollegeID"] = new SelectList(_context.Colleges, "CollegeID", "CollegeID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Athlete).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AthleteExists(Athlete.AthleteID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AthleteExists(int id)
        {
            return _context.Athletes.Any(e => e.AthleteID == id);
        }
    }
}
