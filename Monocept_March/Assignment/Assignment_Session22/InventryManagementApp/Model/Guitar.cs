
namespace InventryManagementApp.Model
{
    internal class Guitar
    {
        private string _serialNumber,_model;
        private Builder _builder;
        private TypeEnum _type;
        private Wood _backWood, _topWood;
        private double _price;

        public Guitar(string serialNumber, double price, Builder builder, string model, TypeEnum type, Wood backWood, Wood topWood)
        {
            _serialNumber = serialNumber;
            _builder = builder;
            _model = model;
            _type = type;
            _backWood = backWood;
            _topWood = topWood;
            _price = price;
        }
        public string SerialNumber
        {
            get { return _serialNumber; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Builder Builder
        {
            get { return _builder; }
        }
        public string Model
        {
            get { return _model; }
        }
        public TypeEnum Type
        {
            get { return _type; }
        }
        public Wood BackWood
        {
            get { return _backWood; }
        }
        public Wood TopWood
        {
            get { return _topWood; }
        }
    }
}
