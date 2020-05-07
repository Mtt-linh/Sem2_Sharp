using System;
using System.Collections.Generic;

namespace Sem2.CorrectASS4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KhVietNam> listvn = new List<KhVietNam>();
            listvn.Add(new KhVietNam(1, "Mai Linh ", "01/2020", 166, "Sinh hoat"));
            List<KhNuocngoai> listNN = new List<KhNuocngoai>();
            listNN.Add(new KhNuocngoai(2, "Alex", "2/2019", 65, "US"));
            listNN.Add(new KhNuocngoai(3, " mikal", "4/2020", 443, "Sinh hoat"));
            int TotalVN = 0;
            foreach (KhVietNam x in listvn)
            {
                TotalVN += x.ThanhTien();
            }

            int TotalNN = 0;
            foreach (KhNuocngoai x in listNN)
            {
                TotalNN += x.ThanhTien();
            }

            System.Console.WriteLine("\nVN :" + TotalVN);
            System.Console.WriteLine("\nNN" + TotalNN);
         
            System.Console.WriteLine("\nTrung binh:");
            System.Console.WriteLine("\nVn :"+ ((float)TotalVN/listvn.Count));
            System.Console.WriteLine("\nNN:"+((float)TotalNN/listNN.Count));
            System.Console.WriteLine("\n Hoa don thang 1/2020");
            foreach (KhVietNam x in listvn)
            {
                
            }
        }


    }
   
}