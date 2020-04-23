using System.Collections.Generic;

namespace Sem2.Session4
{
    public class Dinamond :Product
    {
        private uint cara;

        public Dinamond(int id, string name, uint qty, string image, string desc, List<string> gallery, uint cara) 
            : base(id, name, qty, image, desc, gallery)
        {
            this.cara = cara;
            
        }

        public bool IsReal()
        {
            if (cara > 5) return true;
            return false;
        }
    }
}