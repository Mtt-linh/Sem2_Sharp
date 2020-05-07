using System;
using System.Diagnostics;

namespace Sem2.Session6
{
    // khai baso 1 delegate tra ve  int co hai tham so a , b
    public delegate int IntergerAndInterger(int a, int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            // tao mot doi tuong delegate
            IntergerAndInterger ii = new IntergerAndInterger(Calculator.Add);
            ii += Calculator.Subtract;// nap them ham vao chuoi thuc hien cua delegate 
            ii += new Calculator().division;
            ii(10, 2);// thuc thi cac ham vao delegate
            TaxCalc.TaxMoney tm = TaxCalc.Gettax("VN");
            float tax = tm(10000);
            System.Console.WriteLine(" thue phai nop :"+tax);
           
            //tao 1 ham an danh bang delegate
            TaxCalc.TaxMoney tm2 = delegate(float salary)
            {
                return salary * 40 / 100;
                
            };
            float frTax = tm2(10000);
            System.Console.WriteLine("thue tai nhap :"+frTax);


           ///////////
         
        }
       
    }
}