namespace Sem2.CorrectASS4
{
    public class KhNuocngoai : Khachhang
    {
        private string country;

        public KhNuocngoai(int id, string name, string billDate, int number, string country) : base(id, name, billDate, number)
        {
            this.country = country;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public override int ThanhTien()
        {
            return number * 2000;
        }
    }
}