using System.Collections.Generic;

namespace Sem2.Session4
{
    public delegate void ShowAlert(string msg);
    public class Cart
    {
        private int id;
        private string customer;
        private double granTotal;
        private List<Product> listProduct;
        private string city;
        private string country;
        private event ShowAlert AddToCart;
        public Cart(int id, string customer, double granTotal, List<Product> listProduct, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.granTotal = granTotal;
            this.listProduct = listProduct;
            this.city = city;
            this.country = country;
            if (AddToCart == null)
            {
                AddToCart += AlertMessage;
            }
        }

        public static void AlertMessage(string msg)
        {
            System.Console.WriteLine(msg);
        }
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double GranTotal
        {
            get => granTotal;
            set => granTotal = value;
        }

        public List<Product> ListProduct
        {
            get => listProduct;
            set => listProduct = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public bool AddProduct(Product product)
        {
            listProduct.Add(product); //them tien trong grandTotal
            //phat su kien
            
            return true;
        }

        

        public bool RemoveProduct(Product product)
        {
            return listProduct.Remove(product);
        }

        public double FinalTotal()
        {
            double grand = 0;
            foreach (Product p in listProduct)
            {
                grand += p.price;
            }

            if (Country.Equals("VN") && (City.Equals("HN") || City.Equals("HCM")))
            {
                 grand *= 1.01;
            }
            else if (Country.Equals("HN"))
            {
                 grand *= 1.02;
            }
            else

            {
                 grand *= 1.05;
            }

            grand += ShippingFree(grand);
            this.granTotal = grand;
            return granTotal;
            
        }

        public double ShippingFree(double grand)
        {
            if (Country.Equals("VN") && (City.Equals("HN") || City.Equals("HCM")))
            {
                return grand * 1.01;
            }
            else if (Country.Equals("HN"))
            {
                return grand * 1.02;
            }
            else

            {
                return grand * 1.05;
            }
        }
    }
}