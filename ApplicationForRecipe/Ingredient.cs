using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForRecipe
{
    public class Ingredient
    {  
        // Properties
        public string Name { get; set; }
        public int Calories { get; set; }

        public Ingredient(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }
    }
}
