using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;

namespace Sem2.Session2.assignment_2
{
    public class test
    {
        public static void Main(string[] args)
        {
            Product pt = new Product(1, "linh", 123.4, 12, "linhcute", "DESC");
            
            Product pt = new Product();
            pt.GetInfo();
            pt.instock(12);
            pt.galleryAdd("sfa");
        }
    }
}
