using System;

namespace GenericTypeDynamicArrayApp.Model
{
    internal class MonoceptDynamicArray
    {
        private int[] numbers;
        private int index;
        public MonoceptDynamicArray()
        {
            index = 0;
            numbers = new int[5];
        }
        public void Add(int number)
        {
            if (index == numbers.Length)
                InCreaseCapacity();
            numbers[index++] = number;
        }
        private void InCreaseCapacity()
        {
            int prevCapacity = numbers.Length;
            int[] temporaryArray = numbers;
            numbers = new int[2 * prevCapacity];
            for (int j = 0; j < prevCapacity; j++)
            {
                numbers[j] = temporaryArray[j];
            }
        }
        public int[] Get { get { return numbers; } }
    }
}
