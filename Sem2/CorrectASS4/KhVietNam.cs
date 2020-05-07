namespace Sem2.CorrectASS4
{
    public class KhVietNam : Khachhang
    {
        private string doituong;

        public KhVietNam(int id, string name, string billDate, int number, string doituong) : base(id, name, billDate, number)
        {
            this.doituong = doituong;
        }

        public string Doituong
        {
            get => doituong;
            set => doituong = value;
        }
    }
}