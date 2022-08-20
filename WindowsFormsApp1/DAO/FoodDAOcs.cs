using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class FoodDAOcs
    {
        private static FoodDAOcs instance;
        public static FoodDAOcs Instance
        {
            get { if (instance == null) instance = new FoodDAOcs(); return FoodDAOcs.instance; }
            private set { FoodDAOcs.instance = value; }
        }

        public FoodDAOcs() { }
        public List<FoodDTO> Foodlist_load()
        {
            List<FoodDTO> list = new List<FoodDTO>();
            DataTable pData = dataProvider.Instance.excuteQuerry("SELECT FOODTYPE.name AS 'foodType', FOOD.name AS 'foodName' FROM dbo.FOODTYPE, dbo.FOOD WHERE FOODTYPE.idFOODTYPE = FOOD.idFOODTYPE ");
            foreach(DataRow dataRow in pData.Rows)
            {
                FoodDTO food = new FoodDTO(dataRow);
                list.Add(food);
            }
            return list;
        }
    }
}
