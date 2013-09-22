using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Meal
    {
        public string Name { get; set; }
        public List<MealComponent> MealComponents { get; set; }
        public double Energy
        {
            get
            {
                return MealComponents.Sum(i => i.Energy);
            }
        }

        public Meal()
        {
            MealComponents = new List<MealComponent>();
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
            MealComponents.Add(new MealComponent(ingredient, amountInGrams));
        }
    }
}
