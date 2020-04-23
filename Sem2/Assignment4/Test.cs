using System;
using System.Collections.Generic;

namespace Sem2.Assignment4
{
    public class Test
    {
        public static void Main(string[] args)
        {
            List<Customer> customer = new List<Customer>();

            customer.Add(new Customer(1, "Nguyen Minh Hanh", "Viet Nam", new DateTime(year: 2020, month: 12, day: 26),
                "Sinh hoat", 13, 122.4, 40));
            customer.Add(new Customer(2, "Hoang Thuy Linh ", "Viet Nam", new DateTime(year: 2020, month: 2, day: 22),
                "Kinh doanh", 124345, 112.2, 1000));
            customer.Add(new Customer(3, "Alex Jin", "England", new DateTime(year: 2020, month: 1, 12), "sinh hoat ",
                134, 122.4, 60));

            customer.Add(new Customer(4, "Tran Hai Anh", "Viet Nam ", new DateTime(2020, 3, 4), "san xuat", 354565754,
                100, 1999));
            customer.Add(new Customer(5, " Donald Jason ", "In donesian", new DateTime(2020, 1, 30), "kinh doanh",
                3435, 122.4, 1660));
            Customer i1 = new Customer(1, "Nguyen Minh Hanh", "Viet Nam", new DateTime(year: 2020, month: 12, day: 26),
                "Sinh hoat", 13, 122.4, 40);
            
           Bill hd = new Bill(1,0,0 ,new List<Customer>());
             Console.WriteLine("Tong tin cua khach ntrong nuoc  la :"+ hd.ResultTotal1());
            Console.WriteLine(" Tong tien cua khach nuoc ngoai laf : "+ hd.ResultTotal2());
        }
    }
}