using System;

namespace HumanLib.Model
{
    [Serializable]
    public class Human
    {
        private string _name;
        private readonly string _gender;
        private int _age;
        private double _height;
        private double _weight;

        public Human(string name,string gender, int age, double height, double weight)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _height = height;
            _weight = weight;
        }
        public void WorkOut()
        {
            _weight = _weight - (_weight * .05);
        }
        public void Eat()
        {
            _height = _height + (_height * .02);
            _weight = _weight + (_weight * .10);
        }
        public double BodyMassIndex()
        {
            return (_weight*10000) / (Height * Height);
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string Gender
        {
            get { return _gender; }
        }
    }
}
