using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDateTimeAssignment
{
    public class User
    {
        public User(string firstName, string lastName, string email, string favFootballTeams, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            FavFootballTeams = favFootballTeams;
            Salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FavFootballTeams { get; set; }
        public DateTime DateofBirth { get; set; }
        public TimeSpan LastLogin { get; set; } = new TimeSpan(days: 2, hours: 10, minutes: 5, seconds: 100);
        public decimal Salary { get; set; }

        public bool EmailIsValid()
        {

            // .Contains() method

            if (Email.Contains("@gmail.com"))
            {
                return true;
            }
            return false;
        }

        public string GenerateUsername()
        {

            // .ToLower() method
            // .Join() method
            // Aici stiu ca as fi putut sa fac un string interpolation
            // dar am vrut sa folosesc join. :D

            string[] userDetails = new string[] { FirstName.ToLower(), LastName.ToLower() };
            return String.Join(".", userDetails);
        }

        public string FullName()
        {
            // String interpolation

            return $"{FirstName} {LastName}";
        }

        public void ListFavTeamsAsBulletPoints()
        {
            // .Split() method

            string[] teams = FavFootballTeams.Split(", ");
            foreach (var team in teams)
            {
                Console.WriteLine($"[*] {team}");
            }
        }

        public void ReplaceTeamInString(string oldTeam, string newTeam)
        {
            // .Replace() method
            // .Equals() method

            if (oldTeam.Equals(newTeam, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"Trying to assign the same string: {oldTeam} => {newTeam}");
            }

            else
            {
                FavFootballTeams = FavFootballTeams.Replace(oldTeam, newTeam);
            }
        }

        public string FormatSalary()
        {
            CultureInfo romCurency = new CultureInfo("ro-RO");
            return Salary.ToString("C", romCurency);
        }

        public DateTimeOffset LastJoinedDateFormat()
        {
            return new DateTimeOffset(dateTime: DateofBirth);
        }

    }
}
