using System;
using System.Collections.Generic;

namespace Sem2.Lab3
{
    public class Test
    {
        public static void Main(string[] args)
        {
            product pt = new product(1, "linh", 123.4, 12, "linhcute", "DESC");

            pt.GetInfo();
            pt.instock(12);
            pt.galleryAdd("sfa");
            var list = InsertListFashion();
            System.Console.WriteLine("list san pham");
            display(list);
            Icheck(list, "Black", "M");
            /////////////////////////
            var Lists = Initialized();
            Dcheck(Lists);
            
            /////////
            Eventbuy eby = new Eventbuy();
            eby.ClickButton();
        }
        static List<Fashion> InsertListFashion()
        {
            var list = new List<Fashion>
            {
                new Fashion(1, "Love", 54, 1, "image.jpg", "doc", "black", "M"),
                new Fashion(2, "pig", 435, 45, "picture", "better", "green", "S")
            };
            return list;
        }

        static void display(List<Fashion> list)
        {
            foreach (var dp in list)
            {
                System.Console.WriteLine("Id : " + dp.id +
                                  "\nName: " + dp.name +
                                  "\nQuantity: " + dp.qty +
                                  "\nImange: " + dp.image);
            }
        }

        static void Icheck(List<Fashion> list, string color, string size)
        {
            foreach (var ic in list)
            {
                if (ic.Icheck(color, size))
                {
                    System.Console.WriteLine(" san pham con hang");
                    break;
                }
            }
        }

        static List<Dinamond> Initialized()
        {
            var Lists = new List<Dinamond>
            {
                new Dinamond(1, "b1", 23, 34, "try", "big", 23, 24),
                new Dinamond(2, "b2", 54, 34, "dep", "hit", 25, 14)
            };
            return Lists;
        }

        static void Dcheck(List<Dinamond> Lists)
        {
            foreach (var Cd in Lists)
            {
                if (Cd.realOrFake())
                {
                    System.Console.WriteLine("hang that");
                }
                else
                {
                    System.Console.WriteLine("hang gia ");
                }
            }
        }
    }
}