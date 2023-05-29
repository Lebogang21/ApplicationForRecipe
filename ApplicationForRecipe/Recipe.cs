using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForRecipe
{
    internal class Recipe
    {  // Properties
        
        public string Name { get; set; }
        public double NumIngredients { get; set; }
        public int NumSteps { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int TotalCalories { get; set; }
        public string FoodGroup { get; set; }

        // Method for adding recipe details
        public void AddRecipeDetails()
        {
            Console.Write("Enter recipe name: ");
            Name = Console.ReadLine();

            Console.Write("Enter number of ingredients: ");
            NumIngredients = int.Parse(Console.ReadLine());

            Ingredients = new List<Ingredient>();
            for (int i = 0; i < NumIngredients; i++)
            {
               Ingredient ingredient = new Ingredient();

               Console.Write($"Enter ingredient {i + 1} name: ");
               // ingredient.Name = Console.ReadLine();

                Console.Write($"Enter ingredient {i + 1} calories: ");
                ingredient.Calories = int.Parse(Console.ReadLine());

                Ingredients.Add(ingredient);
            }

            Console.Write("Enter number of steps: ");
            NumSteps = int.Parse(Console.ReadLine());

            Console.Write("Enter food group: ");
            FoodGroup = Console.ReadLine();

            // Calculate total calories
            TotalCalories = Ingredients.Sum(i => i.Calories);
        }

        // Method for displaying recipe details
        public void DisplayRecipeDetails()
        {
            Console.WriteLine($"Recipe: {Name}");
            Console.WriteLine($"Ingredients ({NumIngredients}):");
            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Name} ({ingredient.Calories} calories)");
            }
            Console.WriteLine($"Total calories: {TotalCalories}");
            Console.WriteLine($"Food group: {FoodGroup}");
            Console.WriteLine($"Steps ({NumSteps}):");
            for (int i = 0; i < NumSteps; i++)
            {
                Console.Write($"Step {i + 1}: ");
                Console.WriteLine(NumSteps);
            }
        }

        // Method for scaling recipe by a factor of 0.5, 2, or 3
        public void ScaleRecipe(double factor)
        {
            switch (factor)
            {
                case 0.5:
                    foreach (Ingredient ingredient in Ingredients)
                    {
                        ingredient.Calories /= 2;
                    }
                    break;
                case 2:
                    foreach (Ingredient ingredient in Ingredients)
                    {
                        ingredient.Calories *= 2;
                    }
                    break;
                case 3:
                    foreach (Ingredient ingredient in Ingredients)
                    {
                        ingredient.Calories *= 3;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid factor.");
                    break;
            }

            // calculate total calories
            TotalCalories = Ingredients.Sum(i => i.Calories);
        }
    }
}

