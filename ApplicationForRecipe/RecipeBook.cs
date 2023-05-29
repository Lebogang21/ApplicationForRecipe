using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForRecipe
{
    public class RecipeBook
    {
        public List<Recipe> Recipes { get; set; }

        // Method for adding a recipe to the recipe book
        public void AddRecipe()
        {
            Recipe recipe = new Recipe();
            recipe.AddRecipeDetails();
            Recipes.Add(recipe);
            Console.WriteLine("\nRecipe added to recipe book.");
        }

        // Method for deleting a recipe from the recipe book
        public void DeleteRecipe()
        {
            Console.Write("Enter recipe name to delete: ");
            string recipeName = Console.ReadLine();

            Recipe recipeToDelete = Recipes.FirstOrDefault(r => r.Name.ToLower() == recipeName.ToLower());
            if (recipeToDelete != null)
            {
                Recipes.Remove(recipeToDelete);
                Console.WriteLine($"\nRecipe '{recipeName}' deleted from recipe book.");
            }
            else
            {
                Console.WriteLine($"\nRecipe '{recipeName}' not found in recipe book.");
            }
        }
        

        // Method for displaying all recipes in the recipe book
        public void DisplayRecipes()
        {
            if (Recipes.Count == 0)
            {
                Console.WriteLine("\nNo recipes in recipe book.");
            }
            else
            {
                Console.WriteLine("\nRecipes in recipe book:");
                foreach (Recipe recipe in Recipes)
                {
                    Console.WriteLine(recipe.Name);
                }
            }
        }
    }
}
