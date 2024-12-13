using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace PlayerBank.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if(context.Colleges.Any())
        {
            return;
        }

           context.Colleges.AddRange(
            new College{CollegeName = "UCLA", CollegeCity = "Los Angeles", CollegeState = "California"},
            new College{CollegeName = "Ohio State University", CollegeCity = "Columbus", CollegeState = "Ohio"},
            new College{CollegeName = "U.S. Military Academy", CollegeCity = "West Point", CollegeState = "New York"},
            new College{CollegeName = "Purdue", CollegeCity = "West Lafayette", CollegeState = "Indiana"},
            new College{CollegeName = "Florida A&M University", CollegeCity = "Tallahassee", CollegeState = "Florida"},
            new College{CollegeName = "Wellesley College", CollegeCity = "Wellesley", CollegeState = "Massachusetts"},
            new College{CollegeName = "Stanford University", CollegeCity = "Stanford", CollegeState = "California"},
            new College{CollegeName = "Grambling State University", CollegeCity = "Grambling", CollegeState = "Louisiana"},
            new College{CollegeName = "Eureka College", CollegeCity = "Eureka", CollegeState = "Illinois"},
            new College{CollegeName = "Cal State", CollegeCity = "Los Angeles", CollegeState = "California"},
            new College{CollegeName = "University Of Michigan", CollegeCity = "Ann Arbor", CollegeState = "Michigan"},
            new College{CollegeName = "North Carolina A&T State University", CollegeCity = "Greensboro", CollegeState = "North Carolina"},
            new College{CollegeName = "Macalester College", CollegeCity = "Saint Paul", CollegeState = "Minnesota"},
            new College{CollegeName = "Yale University", CollegeCity = "New Haven", CollegeState = "Connecticut"},
            new College{CollegeName = "Southern Connecticut State University", CollegeCity = "New Haven", CollegeState = "Connecticut"},
            new College{CollegeName = "University of Notre Dame", CollegeCity = "Notre Dame", CollegeState = "Indiana"},
            new College{CollegeName = "University of Tennessee", CollegeCity = "Knoxville", CollegeState = "Tennessee"},
            new College{CollegeName = "University of North Carolina", CollegeCity = "Chapel Hill", CollegeState = "North Carolina"},
            new College{CollegeName = "Rutgers University", CollegeCity = "New Brunswick", CollegeState = "New Jersey"},
            new College{CollegeName = "Cornell University", CollegeCity = "Ithaca", CollegeState = "New York"},
            new College{CollegeName = "Wake Forest University", CollegeCity = "Winston-Salem", CollegeState = "North Carolina"},
            new College{CollegeName = "Brown University", CollegeCity = "Providence", CollegeState = "Rhode Island"},
            new College{CollegeName = "Benedict College", CollegeCity = "Columbia", CollegeState = "South Carolina"},
            new College{CollegeName = "Princeton University", CollegeCity = "Princeton", CollegeState = "New Jersey"}                
            );

        context.SaveChanges();
        Athlete NewAthlete = new Athlete{
            FirstName = "Oscar",
            LastName = "Davila",
            Sport = "Soccer",
            College = context.Colleges.Where(m => m.CollegeName == "Purdue").Single()
        };
        context.Add(NewAthlete);
        context.SaveChanges();
        Athlete athleteTwo = new Athlete{FirstName = "Jackie",LastName = "Robinson",Sport = "Baseball", College = context.Colleges.Where(m => m.CollegeName == "UCLA").Single()};
        context.Athletes.Add(athleteTwo);
        context.SaveChanges();
        Athlete athleteThree = new Athlete{FirstName = "Arthur",LastName = "Ashe",Sport = "Tennis", College = context.Colleges.Where(m => m.CollegeName == "UCLA").Single()};
        context.Athletes.Add(athleteThree);
        context.SaveChanges();
        Athlete athleteFour = new Athlete{FirstName = "Jesse",LastName = "Owens",Sport = "Track and Field", College = context.Colleges.Where(m => m.CollegeName == "Ohio State University").Single()};
        context.Athletes.Add(athleteFour);
        context.SaveChanges();
        Athlete athleteFive = new Athlete{FirstName = "Dwight",LastName = "Eisenhower",Sport = "Football", College = context.Colleges.Where(m => m.CollegeName == "U.S. Military Academy").Single()};
        context.Athletes.Add(athleteFive);
        context.SaveChanges();
        Athlete athleteSix = new Athlete{FirstName = "John",LastName = "Wooden",Sport = "Basketball", College = context.Colleges.Where(m => m.CollegeName == "Purdue").Single()};
        context.Athletes.Add(athleteSix);
        context.SaveChanges();
        Athlete athleteSeven = new Athlete{FirstName = "Althea",LastName = "Gibson",Sport = "Tennis", College = context.Colleges.Where(m => m.CollegeName == "Florida A&M University").Single()};
        context.Athletes.Add(athleteSeven);
        context.SaveChanges();
        Athlete athleteEight = new Athlete{FirstName = "Madeline",LastName = "Albright",Sport = "Swimming and Diving", College = context.Colleges.Where(m => m.CollegeName == "Wellesley College").Single()};
        context.Athletes.Add(athleteEight);
        context.SaveChanges();
        Athlete athleteNine = new Athlete{FirstName = "Jack",LastName = "Nicklaus",Sport = "Golf", College = context.Colleges.Where(m => m.CollegeName == "Ohio State University").Single()};
        context.Athletes.Add(athleteNine);
        context.SaveChanges();
        Athlete athleteTen = new Athlete{FirstName = "Eunice",LastName = "Shriver",Sport = "Swimming", College = context.Colleges.Where(m => m.CollegeName == "Stanford University").Single()};
        context.Athletes.Add(athleteTen);
        context.SaveChanges();
        Athlete athleteEleven = new Athlete{FirstName = "Edward",LastName = "Robinson",Sport = "Football", College = context.Colleges.Where(m => m.CollegeName == "Grambling State University").Single()};
        context.Athletes.Add(athleteEleven);
        context.SaveChanges();
    }
}