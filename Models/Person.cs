using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Person
    {
        private List<Meal> Meals;

        public double EnergyIntake
        {
            get
            {
                // 1 decimal should be enough here
                return Meals.Sum(m => Math.Round(m.Energy, 1));
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
