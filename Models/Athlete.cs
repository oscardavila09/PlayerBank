using System.ComponentModel.DataAnnotations;

namespace PlayerBank.Models;

public class Athlete
{
    public int AthleteID{get;set;}
    [Display(Name = "First Name")]
    [StringLength(10, MinimumLength = 3)]
    public string FirstName{get;set;} = string.Empty;
    [Display(Name = "Last Name")]
    [StringLength(10, MinimumLength = 3)]
    public string LastName{get;set;} = string.Empty;
    public string Sport{get;set;} = string.Empty;
    [Display(Name = "College")]
    public int CollegeID{get;set;}
    public College? College{get;set;} = default!;
}