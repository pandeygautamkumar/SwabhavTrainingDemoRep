namespace HatDecoratorApp.Model.Hats
{
    public class PremiumHat : IHat
    {
        public string GetDescription()
        {
            return "This is a high-quality (Premium) hat made for Specific Use.";
        }

        public string GetName()
        {
            return "Premium Hat";
        }

        public double GetPrice()
        {
            return 540.60;
        }
    }
}
