namespace HatDecoratorApp.Model.Decorators
{
    public abstract class HatDecorator : IHat
    {
        private IHat _hat;
        public HatDecorator(IHat hat)
        {
            _hat = hat;
        }

        public virtual string GetDescription()
        {
            return _hat.GetDescription();
        }

        public virtual string GetName()
        {
            return _hat.GetName();
        }

        public virtual double GetPrice()
        {
            return _hat.GetPrice();
        }
    }
}
