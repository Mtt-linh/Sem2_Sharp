using System.Collections;

namespace Sem2.Assignment5
{
    public abstract class PhoneBook : Phone
    {
        public PhoneBook()
        {
        }

        protected PhoneBook(string name, string phone) : base(name, phone)
        {
        }

        ArrayList PhoneList = new ArrayList();

        public override void InsertPhone(int id, string name, string phone)
        {
            foreach (PhoneBook p in PhoneList)
            {
                if (p.name.Equals(name))
                {
                    if (p.phone.Equals(phone))
                    {
                        System.Console.WriteLine("xin moi nhap lai");
                    }
                    else
                    {
                        
                    }
                    break  ;
                }
            }

            PhoneList.Add(null);
        }
    }
}