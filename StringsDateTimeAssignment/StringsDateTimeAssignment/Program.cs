//String methods
using StringsDateTimeAssignment;
using System.Globalization;

string uFirstName = "Bogdan";
string uLastName = "Aldea";
string uEmail = "bogdan.aldea@gmail.com";
string uFavTeams = "Juventus, Liverpool, Bournemouth, Atalanta";
decimal uSalary = 2100.0m;

User user = new User(uFirstName, uLastName, uEmail, uFavTeams, uSalary);

bool userEmailIsValid = user.EmailIsValid();
Console.WriteLine($"Email entered for user {user.FullName()} is: {userEmailIsValid}");

string username = user.GenerateUsername();
Console.WriteLine($"Generated username for user {user.FullName()} is: {username}");


// Split string and list as bullet points(before .Replace() method)
user.ListFavTeamsAsBulletPoints();

// .Replace() method and assign the old string to the new string
user.ReplaceTeamInString("Atalanta", "Borrusia Dortmund");

// Replace() method but with .Equal() method (assigning the same string to the old one)
user.ReplaceTeamInString("Juventus", "juventus");

// Split string and list as bullet points (after .Replace() 
user.ListFavTeamsAsBulletPoints();

// TimeSpan
Console.WriteLine($"User not logged in for: {user.LastLogin}");

// DateTime
user.DateofBirth = new DateTime(day: 23, month: 6, year: 1993);
Console.WriteLine(user.DateofBirth);

// Currency CultureInfo
Console.WriteLine($"User earns {user.FormatSalary()}");

// Datetime Offset
var d = new DateTimeOffset(dateTime: user.DateofBirth);
Console.WriteLine(d);

