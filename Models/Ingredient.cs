﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public IEnumerable<MacroNutrient> MacroNutrients { get; set; }

        public double Energy 
        {
            get
            {
                return MacroNutrients.Sum(m => Amount * m.Kcal);
            }
        }
    }
}