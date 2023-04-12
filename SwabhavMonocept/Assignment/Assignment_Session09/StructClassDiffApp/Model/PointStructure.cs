using System;

namespace StructClassDiffApp.Model
{
    internal struct PointStructure
    {
        private int x1;
        private int y1;
        public PointStructure(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public int GetX
        {
            get
            {
                return x1;
            }
            set
            {
                x1 = value;
            }
        }
        public int GetY
        {
            get
            {
                return y1;
            }
            set
            {
                y1 = value;
            }
        }
        public void ShowPoint()
        {
            Console.WriteLine("({0},{1})", x1, y1);
        }
    }
}
