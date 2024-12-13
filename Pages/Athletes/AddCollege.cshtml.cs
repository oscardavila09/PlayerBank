using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlayerBank.Models;

namespace PlayerBank.Pages_Colleges;

public class AddCollegeModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<AddCollegeModel> _logger;

    [BindProperty]
    public College College{get;set;} = default!;

    public AddCollegeModel(AppDbContext context, ILogger<AddCollegeModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {

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

    _context.Colleges.Add(College);
    _context.SaveChanges();

    return RedirectToPage("./Index");
    }

}
