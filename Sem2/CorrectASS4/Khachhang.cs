namespace Sem2.CorrectASS4
{
    public class Khachhang
    {
        protected int id;
        protected string name;
        protected string billDate;
        protected int number;

        public Khachhang()
        {
        }

        public Khachhang(int id, string name, string billDate, int number)
        {
            this.id = id;
            this.name = name;
            this.billDate = billDate;
            this.number = number;
        }

        public virtual int ThanhTien()
        {
            if (number<=50)
            {
                return number * 1000;

            }else if (number <= 100)
            {
                return 50 * 1000 + (number - 50) * 1200;
            }else if (number <= 200)
            {
                return 50 * 1000 + 50 * 1200 + (number - 100) * 1500;
            }
            else
            {
                return 50 * 1000 + 50 * 1200 + (number - 200) * 2000;
            }
        }
    }
}