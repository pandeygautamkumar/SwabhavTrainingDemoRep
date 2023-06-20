namespace HatDecoratorApp.Model.Decorators
{
    public class RibbonedHat : HatDecorator
    {
        public RibbonedHat(IHat hat) : base(hat)
        {

        }
        public override string GetName()
        {
            return "Ribboned Wrapped"+base.GetName();
        }
        public override double GetPrice()
        {
            return base.GetPrice()+40.20;
        }
        public override string GetDescription()
        {
            return base.GetDescription()+ " \n\t\t It has a ribbon wrapped around the Hat.";
        }
    }
}
