namespace Sem2.PRACTICAL.Exercise2
{
    public class Base
    {
        
        protected string Name;
        protected int Weight;

        public Base(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string name
        {
            get => Name;
            set => Name = value;
        }

        public int weight
        {
            get => Weight;
            set => Weight = value;
        }

        public virtual void Show()
        {
            System.Console.WriteLine("name: "+name);
            System.Console.WriteLine("Weight: "+weight);
        }

        public virtual void SetMe(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
    }
}