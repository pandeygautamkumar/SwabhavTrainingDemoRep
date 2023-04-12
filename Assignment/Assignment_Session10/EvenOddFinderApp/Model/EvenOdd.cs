using System;
using System.Globalization;

namespace EvenOddFinderApp.Model
{
    internal class EvenOdd
    { 
        public int[] GetEven(int start, int end)
        {
            int[] evenNumber;
            int totalNumber = end - start + 1;
            if (totalNumber % 2 == 0)
                evenNumber = new int[totalNumber / 2];
            else
                evenNumber = new int[totalNumber / 2 + 1];

            int j = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                    evenNumber[j++] = i;
            }
            return evenNumber;
        }

        public int[] GetEven(int end)
        {
            int[] evenNumber;
            if (end % 2 == 0)
                evenNumber = new int[end / 2];
            else
                evenNumber = new int[end / 2 + 1];

            int j = 0;
            for (int i = 1; i <= end; i++)
            {
                if (i % 2 == 0)
                    evenNumber[j++] = i;
            }
            return evenNumber;
        }
        public int[] GetOdd(int start,int end)
        {
            int[] oddNumber;
            int totalNumber = end - start + 1;
            if (totalNumber % 2 == 0)
                oddNumber = new int[totalNumber / 2];
            else
                oddNumber = new int[totalNumber / 2 + 1];

            int j = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                    oddNumber[j++] = i;
            }
            return oddNumber;
        }
        public int[] GetOdd(int end)
        {
            int[] oddNumber;
            if(end%2==0)
                oddNumber= new int[end/2];
            else
                oddNumber= new int[end/2+1];

            int j = 0;
            for(int i = 1; i <= end; i++)
            {
                if(i%2!=0)
                    oddNumber[j++]= i;
            }
            return oddNumber;
        }

    }
}
