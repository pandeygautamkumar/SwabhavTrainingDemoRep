
namespace CalculatorEventApp.Model
{
    delegate void DMatOperations(int n1, int n2,string result);
    internal class Calculator
    {
        public event DMatOperations AdditionCompleted = null;
        public event DMatOperations SubstractionCompleted = null;
        public void Add(int n1,int n2)
        {
            string result = $"Addition is : {n1 + n2}";
            if (AdditionCompleted != null)
            {
                AdditionCompleted(n1,n2,result);
            }
        }
        public void Substract (int n1, int n2)
        {
            string result = $"substraction is : {n1 - n2}";
            if (SubstractionCompleted != null)
            {
                SubstractionCompleted(n1, n2,result);
            }
        }
    }
}
