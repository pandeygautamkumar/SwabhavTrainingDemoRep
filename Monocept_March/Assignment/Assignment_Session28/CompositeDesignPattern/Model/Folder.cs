
using System;
using System.Collections.Generic;

namespace CompositeDesignPattern.Model
{
    internal class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> _children;
        public Folder(string name)
        {
            _name = name;
            _children= new List<IStorageItem>();    
        }
        public void AddChild(IStorageItem item)
        {
            _children.Add(item);
        }
        public void Display(int depth = 0)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("  ");
            }
            Console.WriteLine("{0}", _name);
            foreach (IStorageItem item in _children)
            {
                int temp = depth;
                item.Display(++temp);
            }
        }
    }
}
