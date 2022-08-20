using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApp1.DTO
{
    internal class billInfor
    {

        public billInfor() { }

        public billInfor(string a, int b, float c, float d)
        {
            Name = a;
            Count = b;
            Price = c;
            Discount = d;
            TotalPrice = Price * Count;
            TotalPrice -= (TotalPrice * Discount);
        }

        public billInfor(DataRow pData)
        {
            Name = pData["name"].ToString();
            Count = (int)pData["count"];
            Price = (float)Convert.ToDouble(pData["FoodPrice"].ToString());
            Discount = 0;
            TotalPrice = Price * Count;
            TotalPrice -= (TotalPrice * Discount); 
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int count;
        public int Count { 
            get { return count; }
            set { count = value; }
        }

        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private float discount;
        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }


    }
}
