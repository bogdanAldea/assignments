using GenericsCollectionsAssignment;


string[] array = new string[10];
IGenericCollection<string> stringCollection = new GenericCollection<string>(array);


// Set element at index
stringCollection.Set(item: "A", index: 0);
stringCollection.Set(item: "B", index: 1);
stringCollection.Set(item: "C", index: 2);
stringCollection.Set(item: "D", index: 3);
stringCollection.Set(item: "E", index: 4);

// Print each element in array (before .Swap() method)
Console.WriteLine("Listing elements before swapping some of them");
for (int index = 0; index < stringCollection.GetLength(); index++)
{
    string valueAtIndex = stringCollection.Get(index) ?? "No Value Added.";
    Console.WriteLine($"Value at index {index} is : {valueAtIndex}");
}

// Swap elements
stringCollection.Swap(indexA: 2, indexB: 7);
stringCollection.Swap(indexA: 3, indexB: 8);


// Print each element in array (after .Swap() method)
Console.WriteLine("Listing elements after swapping some of them");
for (int index = 0; index < stringCollection.GetLength(); index++)
{
    string valueAtIndex = stringCollection.Get(index) ?? "No Value Added.";
    Console.WriteLine($"Value at index {index} is : {valueAtIndex}");
}