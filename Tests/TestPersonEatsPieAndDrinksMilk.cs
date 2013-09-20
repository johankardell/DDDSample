using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class TestPersonEatsPieAndDrinksMilk
    {
        private Meal pie;
        private Meal glassOfMilk;
        private Meal largeGlassOfMilk;

        private Ingredient milkAsIngredient = new Ingredient
        {
            Name = "Milk",
            MacroNutrients = new List<MacroNutrient>
                                {
                                    new Carbohydrate {Amount = 5},
                                    new Fat {Amount = 3},
                                    new Protein {Amount = 3.3}
                                }
        };

        [TestInitialize]
        public void Initialize()
        {
            pie = new Meal("Pie");
            glassOfMilk = new Meal("Glass of milk", milkAsIngredient, 100);
            largeGlassOfMilk = new Meal("Glass of milk", milkAsIngredient, 250);
        }

        [TestMethod]
        public void PersonEatsPie_MealRegistered()
        {
            var person = new Person();

            person.Eat(pie);

            Assert.AreEqual(1, person.Meals.Count);
        }

        [TestMethod]
        public void PersonDrinks100gMilk_60kcalReturned()
        {
            var person = new Person();

            person.Eat(glassOfMilk);

            Assert.AreEqual(60.2, person.EnergyIntake);
        }

        [TestMethod]
        public void PersonDrinks250gMilk_150kcalReturned()
        {
            var person = new Person();

            person.Eat(largeGlassOfMilk);

            Assert.AreEqual(150.5, person.EnergyIntake);
        }
    }
}
