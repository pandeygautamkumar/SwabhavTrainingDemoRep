namespace HatDecoratorApp.Model.Decorators
{
    public class GoldenHat : HatDecorator
    {
        public GoldenHat(IHat hat) : base(hat)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription()+ " \n\t\t It has a layer of Golden Color.";
        }
        public override string GetName()
        {
            return "Golden Colored "+base.GetName();
        }
        public override double GetPrice()
        {
            return base.GetPrice()+200.10;
        }
    }
}
