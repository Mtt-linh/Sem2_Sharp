using System.Collections.Generic;

namespace Sem2.Session2.assignment_2
{
    public class Fashion : Product
    {
        public string color;
        public string size;

        public Fashion(int id, string name, double price, int qty, string image, string desc, string color, string size)
            : base(id, name, price, qty, image, desc)
        {
            this.color = color;
            this.size = size;
        }

        public Fashion()
        {
        }

        public string GetColor()
        {
            return color;
        }

        public string GetSize()
        {
            return size;
        }

        public bool Icheck(string color, string size)
        {
            if (GetColor().Equals(color) && GetSize() == size)
            {
                return true;
            }

            return false;
        }
    }
}