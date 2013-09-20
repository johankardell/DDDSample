using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        public List<Meal> Meals;

        public double EnergyIntake
        {
            get
            {
                return Meals.Sum(m => m.Energy);
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
