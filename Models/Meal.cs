using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Meal
    {
        public string Name { get; set; }
        public List<Recipe> Recipes { get; set; }
        public double Energy
        {
            get
            {
                return Recipes.Sum(i => i.Energy);
            }
        }

        public Meal()
        {
            Recipes = new List<Recipe>();
        }

        public Meal(string name)
            : this()
        {
            Name = name;
        }

        public Meal(string name, Ingredient ingredient, double amountInGrams)
            : this(name)
        {
            Add(ingredient, amountInGrams);
        }

        public void Add(Ingredient ingredient, double amountInGrams)
        {
            Recipes.Add(new Recipe(ingredient, amountInGrams));
        }
    }
}
