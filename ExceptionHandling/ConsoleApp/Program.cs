using System;
using ExceptionsLibrary;
using Models;


string inredientName = null;
string ingredientCategory = null;


try
{
    ExceptionHandling.AddIngredientToRecipe("Test string", ingredientCategory, 10);
}
catch (NullReferenceException exception)
{

    Console.WriteLine(exception.Message);
    ExceptionHandling.LogToTxtFile(exception); // this runs only in debug mode
}