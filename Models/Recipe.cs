using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Recipe
    {
        public string Name { get { return Ingredient.Name; } }

        public Ingredient Ingredient { get; set; }
        
        public double AmountInGrams { get; set; }
        
        public double Energy
        {
            get
            {
                return Ingredient.EnergyPerGram * AmountInGrams;
            }
        }

        public Recipe(Ingredient ingredient, double amountInGrams)
        {
            Ingredient = ingredient;
            AmountInGrams = amountInGrams;
        }
    }
}
