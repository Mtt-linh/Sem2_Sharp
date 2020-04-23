using System;
using System.Collections.Generic;

namespace Sem2.Session4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Dinamond(1,"San pham 1",3000,"anh.jpg","anh 1",new List<string>(),3);
            p1.AddGallery("ANH 2");
            Fashion F1 = new Fashion(2,"quan ao",1500,"image.jpg","mo ta sp ",new List<string>(),"red",27 );
            Dinamond d1 = new Dinamond(3,"kim cuong 18 cara",15500,"image","anh.png ",new List<string>(), 3);
            Cart c1 = new Cart(1," mai linh ",0 , new List<Product>(),"Hd","hn" );
            c1.AddProduct(p1);
            c1.AddProduct(F1);
            c1.AddProduct(d1);
            Console.WriteLine(" tong tien phai thah toan: " + c1.FinalTotal());
        }
    }
}