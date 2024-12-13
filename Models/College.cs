using System.ComponentModel.DataAnnotations;

namespace PlayerBank.Models;
public class College
{
    public int CollegeID{get;set;}
    [Display(Name ="College")]
    public string CollegeName{get;set;} = string.Empty;
    [Display(Name ="State")]
    public string CollegeState{get;set;} = string.Empty;
    [Display(Name ="City")]
    public string CollegeCity{get;set;} = string.Empty;
    public List<Athlete> Athletes{get;set;} = default!;
}