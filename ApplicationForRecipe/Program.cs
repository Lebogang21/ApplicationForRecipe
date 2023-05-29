using ApplicationForRecipe;

internal class Program
{
    private static void Main(string[] args)
    {
        RecipeBook recipeBook = new RecipeBook();

        while (true)
        {
           // Displaying items in alphabetical order
            
            Console.WriteLine("\nEnter an option:\nA - Add recipe\nD - Delete recipe\nL - List recipes\nS - Scale recipe\nQ - Quit");
            string input = Console.ReadLine();


            switch (input.ToUpper())
            {
                case "A":
                    recipeBook.AddRecipe();
                    break;
                case "D":
                    recipeBook.DeleteRecipe();
                    break;
                case "L":
                    recipeBook.DisplayRecipes();
                    break;
                case "S":
                    Console.Write("Enter recipe name to scale: ");
                    string recipeName = Console.ReadLine();

                    Recipe recipeToScale = recipeBook.Recipes.FirstOrDefault(r => r.Name.ToLower() == recipeName.ToLower());
                    if (recipeToScale != null)
                    {
                        Console.Write($"Enter scaling factor (0.5, 2, or 3) for recipe '{recipeName}': ");
                        int factor = int.Parse(Console.ReadLine());

                        recipeToScale.ScaleRecipe(factor);
                        Console.WriteLine("\nRecipe scaled.");
                    }
                    else
                    {
                        Console.WriteLine($"\nRecipe '{recipeName}' not found in recipe book.");
                    }
                    break;
                case "Q":
                    Console.WriteLine("\nGoodbye!");
                    return;
                default:
                    Console.WriteLine("\nInvalid option.");
                    break;
            }
        }

    }
}