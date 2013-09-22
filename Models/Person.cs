using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        private List<Meal> Meals;

        public double EnergyIntake
        {
            get
            {
                return Meals.Sum(m => Math.Round(m.Energy,1));
            }
        }

        public int NumberOfMealsEaten
        {
            get
            {
                return Meals.Count;
            }
        }

        public Person()
        {
            Meals = new List<Meal>();
        }

        public void Eat(Meal meal)
        {
            Meals.Add(meal);
        }
    }
}
