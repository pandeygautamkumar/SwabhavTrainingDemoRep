using System;

namespace CalculatorTestApp1.Model
{
    internal class Calculator
    {
        public int CubeEvenNo(int no)
        {
            if (no % 2 == 0)
            {
                return (no * no * no);
            }
            return -1;
        }
        public int Add(params int[] numbers)
        {
            int total = 0;
            foreach(int number in numbers)
            {
                total += number;
            }
            return total;
        }
    }
}
