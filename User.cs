using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class User
    {
        private string name;
        private string email;
        private ShoppingCart order;

        public User(string name, string email, string street, string city, string zipCode)
        {
            this.name = name;
            this.email = email;
            order = new ShoppingCart(street, city, zipCode);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void AddOrder(string size, string color, float price)
        {
            order.AddOrder(size, color, price);
        }

        public float Total()
        {
            return order.GetTotal();
        }

        public void Orders()
        {
            order.PrintAllOrders();
        }
    }
}
