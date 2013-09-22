namespace Models
{
    public abstract class MacroNutrient
    {
        protected abstract double KcalPer100g { get; }
        public double Amount { get; set; }
        public double Kcal
        {
            get
            {
                return (Amount * KcalPer100g) / 100;
            }
        }
    }

    public class Carbohydrate : MacroNutrient
    {
        protected override double KcalPer100g
        {
            get { return 4; }
        }
    }

    public class Protein : MacroNutrient
    {
        protected override double KcalPer100g
        {
            get { return 4; }
        }
    }

    public class Fat : MacroNutrient
    {
        protected override double KcalPer100g
        {
            get { return 9; }
        }
    }
}
