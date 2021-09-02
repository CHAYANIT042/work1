using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class TShirt
    {
        private string size;
        private string color;
        private float price;
        private string image;

        public TShirt(string size, string color, float price)
        {
            this.size = size;
            this.color = color;
            this.price = price;
        }

        public void SetSize(string size)
        {
            this.size = size;
        }

        public string GetSize()
        {
            return size;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetPrice(float price)
        {
            this.price = price;
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetImage(string image)
        {
            this.image = image;
        }

        public string GetImage()
        {
            return image;
        }
    }
}
