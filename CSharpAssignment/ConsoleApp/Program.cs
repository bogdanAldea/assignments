using Models;

Building building = new Building();
building.Add(new Apartment { FloorNumber = 1, Number = 1 });
building.Add(new Apartment { FloorNumber = 1, Number = 2 });
building.Add(new Apartment { FloorNumber = 2, Number = 3 });
building.Add(new Apartment { FloorNumber = 2, Number = 4 });
building.Add(new Apartment { FloorNumber = 3, Number = 5 });
building.Add(new Apartment { FloorNumber = 3, Number = 6 });

foreach (var x in building)
{
    Console.WriteLine(x);
}