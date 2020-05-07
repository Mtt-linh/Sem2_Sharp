using System;
using System.Collections.Generic;

namespace Sem2.Session4
{
    public class Product
    {
        protected int id;
        protected string name;
        public double price;
        protected uint qty; //uint so luong kgong am 
        protected string image;
        protected string desc;
        protected List<string> gallery;
        private event ShowAlert ChangeQty;
        public Product()
        {
            this.gallery = new List<string>();
            if (ChangeQty == null)
            {
                ChangeQty += Cart.AlertMessage;
            }
        }

        public Product(int id, string name, uint qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public string this[int Index]
        {
            get { return gallery[Index]; }
            set { gallery[Index] = value; }
        }

        public static int YearCode; // static ptopertic

        // {
        //   get => YearCode;
        // set => YearCode = value;
        //}
        public int Id // khai bao 1 proterties
        {
            get => id; //ham tra ve gia tri read
            set => id = value; // ham set gia tri -- qrite 
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public uint Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            set => gallery = value;
        }

        public void GetInfo()
        {
            System.Console.WriteLine("ID: " + this.id + "Name : " + this.name + "Quantity :" + this.qty + "Price " + price +
                                     "Image" + this.image);
        }

        public bool CheckStock()
        {
            if (qty > 0) return true;
            return false;
        }

        public bool AddGallery(string image)
        {
            if (gallery.Count >= 10)
            {
                System.Console.WriteLine(" anh da vuot qua so luong can xoa bot ");
                return false;
            }

            //Console.WriteLine("nhap link anh");
            //string new_image = Console.ReadLine();
            //gallery.Add(new_image);
            gallery.Add(image);
            return true;
        }

        public void DeleteGallery()
        {
            System.Console.WriteLine("danh sach anh :");
            for (int i = 0; i < gallery.Count; i++)
            {
                System.Console.WriteLine(i + ". " + gallery[1]);
            }

            System.Console.WriteLine(" chon anh de xoa :");
            int stt = Convert.ToInt32(System.Console.ReadLine());
            gallery.RemoveAt(stt);
        }

        public bool DeleteImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool DeleteAt(int number)
        {
            if (number < gallery.Count && number > 0)
            {
                gallery.RemoveAt(number);
                return true;
            }

            return false;
        }
    }
}