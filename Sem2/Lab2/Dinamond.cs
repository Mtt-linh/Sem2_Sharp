namespace Sem2.Session2.assignment_2
{
    public class Dinamond : product
    {
        private float weight;
        private float size;

        public Dinamond(int id, string name, double price, int qty, string image, string desc, float weight,
            float size) :
            base(id, name, price, qty, image, desc)
        {
            this.weight = weight;
            this.size = size;
        }

        public bool realOrFake()
        {
            if (Price>10)
            {
                return true;
            }

            return false;
        }
        
    }

    public partial class product
    {
        protected product(in int id, string name, in double price, in int qty, string image, string desc)
        {
            throw new System.NotImplementedException();
        }
    }
}