
namespace GenericDynamicArrayShoppingCardApp.Model
{
    internal class DynamicArray<T>
    {
        private T[] items;
        private int index;
        public DynamicArray()
        {
            index = 0;
            items = new T[5];
        }
        public void Add(T item)
        {
            if (index == items.Length)
                InCreaseCapacity();
            items[index++] = item;
        }
        private void InCreaseCapacity()
        {
            int prevCapacity = items.Length;
            T[] temporaryArray = items;
            items = new T[2 * prevCapacity];
            for (int j = 0; j < prevCapacity; j++)
            {
                items[j] = temporaryArray[j];
            }
        }
        public T[] Get { get { return items; } }
        public int Count { get { return items.Length; } }
    }
}
