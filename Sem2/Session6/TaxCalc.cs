namespace Sem2.Session6
{
    public class TaxCalc
    {
        public delegate  float TaxMoney (float salary);
        public static float VietNamtax(float salary)
        {
            return 10 * salary / 100;
        }

        public static float UASTax(float salary)
        {
            return 15 * salary / 100;
        }

        public static float Othertax(float salary)
        {
            return 5 * salary / 100;
            
        }
// viet ham tra ve 1 ham bang delegate 
        public static TaxMoney Gettax(string coutry)
        {
            if ( coutry == "VN")
            {
                return VietNamtax;
            }else if (coutry == "US")
            {
                return UASTax;
            }
            else
            {
                return Othertax;
            }
        }
    }

  
}