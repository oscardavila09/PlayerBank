using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlayerBank.Models;

namespace PlayerBank.Pages_Athletes;

public class AddAthleteModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<AddAthleteModel> _logger;

    [BindProperty]
    public Athlete Athlete{get;set;} = default!;

    public SelectList CollegesDropDown {get;set;} = default!;

    public AddAthleteModel(AppDbContext context, ILogger<AddAthleteModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        CollegesDropDown = new SelectList(_context.Colleges.ToList(), "CollegeID", "CollegeName");
    }
    public IActionResult OnPost()
    {
    if (!ModelState.IsValid)
    {
        var allErrors = ModelState.Values.SelectMany(v => v.Errors);
        foreach (var e in allErrors)
        {
            _logger.LogError($"Error: {e.ErrorMessage}");
        }
        return Page();
    }

    _context.Athletes.Add(Athlete);
    _context.SaveChanges();

    return RedirectToPage("./Index");
    }
}
