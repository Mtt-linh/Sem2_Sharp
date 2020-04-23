using System.Collections.Generic;

namespace Sem2.Session4
{
    public class Cart
    {
        private int id;
        private string Customer;
        private double granTotal;
        private List<Product> listProduct;
        private string City;
        private string Country;

        public Cart(int id, string customer, double granTotal, List<Product> listProduct, string city, string country)
        {
            this.id = id;
            Customer = customer;
            this.granTotal = granTotal;
            this.listProduct = listProduct;
            City = city;
            Country = country;
        }

        public bool AddProduct(Product product)
        {
            listProduct.Add(product); //them tien trong grandTotal
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