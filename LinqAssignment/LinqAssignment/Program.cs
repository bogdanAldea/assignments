using LinqAssignment.Core;
using LinqAssignment.ExtensioMethods;
using System.Collections;

IEnumerable<Manager> managers = new ManagerRepository().Create();
IEnumerable<Player> players = new PlayerRepository().Create();
IEnumerable<Team> teams = new TeamRepository().Create();


// Filtering Operators //

// Where
var expensivePlayers = players.Where(player => player.TransferMarketValue > 60000000);

// Take with OrdeByDescending
var mostRichTeams = teams.OrderByDescending(team => team.TransferBudget).Take(3);

// Skip with OrderByDescending
var oldestPlayers = players.OrderByDescending(player => player.Age).Skip(4);

// TakeWhile
var aboveSalary = players.TakeWhile(player => player.ContractDuration.Wage > 2500000);


// Projection Operators //

// Select

var playersAtTeam = players.Select(player => player.LastName);

// Join Operators //

// Join(method syntax)
var playersAtTeamsMethodSyntax = players.Join(
        teams,
        player => player.TeamId,
        team => team.Id,
        (player, team) => new { player, team.Name });

// Join(query syntax)
var playersAtTeamsQuerySyntax = from player in players
                                join team in teams on player.TeamId equals team.Id
                                select new { player, team.Name };

// Zip
var playerAtTeamZip = players.Zip(teams, (player, team) => $"{player} ({team.Name})");


// Ordering Operations //

// OrderBy ThenBy
var expensivePlayersToSell = players.OrderByDescending(player => player.Age).ThenByDescending(player => player.ContractDuration.Wage).Where(player => player.Age > 30);

// Reverse
// Order teams by how rich they are and then reverse the result
var richTeams = teams.OrderByDescending(team => team.TransferBudget).Reverse();

// Grouping Operators //
// GroupBy

var groupByAge = players.GroupBy(
        player => player.ContractDuration.Wage,
        player => player.ContractDuration,
        (key, value) => new { Wage = key, Contract = value });


// Set Operators//

// Union
var unionTeams = players.Select(player => player.TeamId)
    .Union(managers.Select(manager => manager.TeamId));

// Intersect
List<string> playersWithYellowCards = new List<string>() { "Chiellini", "van Dijk", "de Ligt" };
List<string> playersWithRedCards = new List<string>() { "de Ligt", "Cuadrado" };

var mostAggresivePlayers = playersWithYellowCards.Intersect(playersWithRedCards);

// Except
var playersWithNoRedCards = playersWithYellowCards.Except(playersWithRedCards);


// Conversion Methods

// OfType
ArrayList items = new ArrayList() { "string A", "string B", true, 2};

IEnumerable<string> stringItems = items.OfType<string>();
IEnumerable<int> intItems = items.OfType<int>();

//Cast
ArrayList values = new ArrayList() { 10, 2, 4, 8 };
IEnumerable<int> intValues = values.Cast<int>();

//ToArray
double[] salaries = players.Select(player => player.ContractDuration.Wage).ToArray();

//ToList
List<string> teamNames = teams.Select(team => team.Name).ToList();

//ToDictionary
Dictionary<int, Team> teamDict = teams.ToDictionary(team => team.Id);


//ToLookup
var playersByTeam = players.ToLookup(player => player.TeamId);

//foreach (var group in playersByTeam)
//{
//    Console.WriteLine($"Team id: {group.Key}");

//    foreach (var player in group)
//    {
//        Console.WriteLine($"\t {player}");
//    }

//}

// AsEnumerable
IEnumerable<double> salaries2 = managers.Select(manager => manager.ContractDuration.Wage).AsEnumerable();


// Element Operators //

// FIrst, FirstOrDefault
List<double> prices = new List<double>() { 44, 10, 5, 6, 140, 11, 10 };
var firstPriceLargerThatTen = prices.FirstOrDefault(price => price > 10);

// Last, LastOrDefault
var lastPriceLargerThanTen = prices.LastOrDefault(price => price > 10);

// Single, SingleOrDefault
var singlePrice = prices.Single(price => price == 11);

// ElementAt, ElementAtOrDefault
var priceAt = prices.ElementAt(5);



// Aggregation Methods //

// Count, LongCount
var numhOfHighPlayerSalaries = players.Where(player => player.ContractDuration.Wage > 3000000).Count();

// Min, Max
var playerAges = players.Select(player => player.Age);
var youngest = playerAges.Min();
var oldest = playerAges.Max();


var salariesAtSomeTeam = players
    .Where(player => player.TeamId == 1)
    .Select(player => player.ContractDuration.Wage);

// Sum
var totalSalariesExpenses = salariesAtSomeTeam.Sum();

// Average
var averageSalaryAtTeam = salariesAtSomeTeam.Average();


// Quantifiers //

// Contains
var teamExists = managers.Select(manager => manager.TeamId).Contains(2);

// Any
var anyTeam = teams.Any(team => team.TransferBudget > 50000000);

// All
var allTeams = teams.All(team => team.TransferBudget == 50000000);

// SequenceEqual

var youngPlayers = players.Where(player => player.Age <= 27);
var oldPlayers = players.Where(players => players.Age > 27);
var seqAreEqual = youngPlayers.SequenceEqual(oldPlayers);

// Generation Methods //

// Empty
IEnumerable<Player> somDates = players.Where(player => player.TeamId == 6) ?? Enumerable.Empty<Player>();

// Repeat
IEnumerable<string> repeatString = Enumerable.Repeat("string to repeat", 9);

// Range
IEnumerable<int> rangeNumbers = Enumerable.Range(6, 22);