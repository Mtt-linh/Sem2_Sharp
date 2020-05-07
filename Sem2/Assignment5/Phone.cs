using Sem2.Session3;

namespace Sem2.Assignment5
{
    public abstract class Phone
    {
        protected string name;
        protected string phone;

        public Phone()
        {
        }

        public Phone(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }


        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phone1
        {
            get => phone;
            set => phone = value;
        }

        public abstract void InsertPhone(int id, string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newPhone);
        public abstract void SearchPhone(string name);
    }
}