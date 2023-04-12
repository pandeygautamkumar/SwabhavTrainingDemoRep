
namespace StudentApp.Model
{
    internal class Student
    {
        private int _rollNo;
        private string _name;
        private double _cgpa;

        public Student(int rollNo,string name,double cgpa)
        {
            _rollNo = ValidateRollNo(rollNo);
            _name = ValidateName(name);
            _cgpa = ValidateCgpa(cgpa);
        }
        public int RollNo
        {
            get
            {
                return _rollNo; 
            }
            set
            {
                _rollNo = ValidateRollNo(value);
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = ValidateName(value);
            }
        }
        public double Cgpa
        {
            get
            {
                return _cgpa;
            }
            set
            {
                _cgpa = ValidateCgpa(value);
            }
        }
        public double CalculatePercentage()
        {
            return (_cgpa * 9.5);
        }
        private string ValidateName(string name)
        {
            if (name.Length>=5)
            {
                return name;
            }
            else
            {
                return "";
            }
        }
        private double ValidateCgpa(double cgpa)
        {
            if (cgpa<1)
            {
                return 0;
            }
            else if(cgpa>10)
            {
                return 10;
            }
            else
            {
                return cgpa;
            }
        }
        private int ValidateRollNo(int rollNo)
        {
            if (rollNo > 0)
                return rollNo;
            else
                return 0;
        }
    }
}
