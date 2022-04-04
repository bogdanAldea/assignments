using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public static class ExceptionHandling
    {

        public static Ingredient CreateIngredient(string name, string category)
        {
            Ingredient ingredient = new Ingredient();

            if ((name == null && category == null) || (name == null || category == null))
            {
                throw new NullReferenceException();
            }

            ingredient.Name = name;
            ingredient.Category = category;

            return ingredient;
        }

        public static void AddQuantityToIngredient(Ingredient ingredient, double quantity)
        { 
            
            if (quantity < 0)
            {
                throw new QuantityIsNegativeException("Quantity cannot be smaller than 0");
            }

            ingredient.Quantity = quantity;
        }

        public static void AddIngredientToRecipe(string name, string category, double quantity)
        {

            try
            {
                
                Console.WriteLine("Connecting to database to save ingredient...");
                
                Ingredient ingredient = CreateIngredient(name, category);
                
                AddQuantityToIngredient(ingredient, quantity);
                
            }
            catch (NullReferenceException)
            {

                throw;

            }
            catch (QuantityIsNegativeException)
            {

                throw;

            }
            finally
            {
                Console.WriteLine("Closing connection to database...");
            }

            
        }

#if DEBUG
        public static void LogToTxtFile(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
#endif
    }
}
