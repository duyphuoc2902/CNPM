using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApp1.DTO
{
    internal class FoodDTO
    {
        public FoodDTO() { }
        private string foodType;
        public string FoodType { get { return foodType; } set { foodType = value; } }

        private string foodName;
        public string FoodName { get { return foodName; } set { foodName = value; } }

        public FoodDTO(string a, string b) { FoodType = a; FoodName = b; }
        
        public FoodDTO(DataRow pData)
        {
            FoodType = pData["foodType"].ToString();
            FoodName = pData["foodName"].ToString();
        }
    }
}
