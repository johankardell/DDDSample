namespace Models
{
    public class MealComponent
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

        public MealComponent(Ingredient ingredient, double amountInGrams)
        {
            Ingredient = ingredient;
            AmountInGrams = amountInGrams;
        }
    }
}
