namespace HatDecoratorApp.Model.Hats
{
    public class StandardHad : IHat
    {
        public string GetDescription()
        {
            return "This is a Standard(basic) hat for everyday use.";
        }

        public string GetName()
        {
            return "Standard Hat";
        }

        public double GetPrice()
        {
            return 110.75;
        }
    }
}
