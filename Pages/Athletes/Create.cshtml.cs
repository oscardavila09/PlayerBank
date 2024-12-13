using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlayerBank.Models;

namespace PlayerBank.Pages_Athletes
{
    public class CreateModel : PageModel
    {
        private readonly PlayerBank.Models.AppDbContext _context;

        public CreateModel(PlayerBank.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CollegeID"] = new SelectList(_context.Colleges, "CollegeID", "CollegeID");
            return Page();
        }

        [BindProperty]
        public Athlete Athlete { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Athletes.Add(Athlete);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
