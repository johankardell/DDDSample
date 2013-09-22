using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Meal
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public double Energy
        {
            get
            {
                return Ingredients.Sum(i => i.Energy);
            }
        }

        public Meal()
        {
            Ingredients = new List<Ingredient>();
        }

        public Meal(string name)
            : this()
        {
            Name = name;
        }

        public Meal(string name, Ingredient ingredient, double amount)
            : this(name)
        {
            Add(ingredient, amount);
        }


        public void Add(Ingredient ingredient, double amount)
        {
            // TODO: Rewrite? Better way of copying object data without manually copying each property
            var i = new Ingredient
            {
                AmountInGrams = amount,
                MacroNutrients = ingredient.MacroNutrients,
                Name = ingredient.Name
            };
            Ingredients.Add(i);
        }
    }
}
