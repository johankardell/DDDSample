using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Ingredient
    {
        public string Name { get; set; }

        public IEnumerable<MacroNutrient> MacroNutrients { get; set; }

        public double EnergyPerGram 
        {
            get
            {
                return MacroNutrients.Sum(m => m.Kcal);
            }
        }
    }
}
