using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    internal class Menu
    {
        Menu() { }
        Menu(string a, int b, float c, float d)
        {
            FoodName = a;
            Count = b;
            Price = c;
            TotalPrice = d;
        }
        Menu(DataRow p)
        {
            FoodName = p["name"].ToString();
        }
        private string foodName;
        public string FoodName
        {
            get { return FoodName; }
            set { FoodName = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
