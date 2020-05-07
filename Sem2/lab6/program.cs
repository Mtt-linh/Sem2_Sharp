using System;

namespace Sem2.lab6
{
    public class program
    {
        public static void Main(string[] args)
        {
            int choose;
            do
            {
                ShowMenu();
                 choose = chose();
                if (choose> 0 && choose < 5)
                {
                    System.Console.WriteLine("nhap so thu nhat :");
                    int no1 = chose();
                    System.Console.WriteLine("\n nhap so thu 2 :");
                    int no2 = chose();
                    Math mn = Calc.GetFunction(choose);
                    switch (choose)
                    {
                        case 1 : System.Console.WriteLine("Tong hai so " + mn(no1,no2));
                            break;
                        case 2: System.Console.WriteLine("hieu hai so :"+mn(no1,no2));
                            break;
                        case 3: System.Console.WriteLine(" tich hai so : " +mn(no1,no2));
                            break;
                        case 4 : System.Console.WriteLine("thuong hai so :"+mn(no1,no2));
                            break;
                    }
                }
                
            } while (choose != 0);
        }

        public static void ShowMenu()
        {
            System.Console.WriteLine(" \nlua chon chuc nang :  ");
            System.Console.WriteLine("1.Cong ");
            System.Console.WriteLine("2.tru ");
            System.Console.WriteLine("3.nhan ");
            System.Console.WriteLine("4.chia ");
            System.Console.WriteLine("0.thoat ");


        }

        public static int chose()
        {
            return Convert.ToInt32(System.Console.ReadLine());
        }
    }
}