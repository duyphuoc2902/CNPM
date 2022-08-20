using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAO
{
    internal class BillInforDAO
    {
        private static BillInforDAO instance;
        public static BillInforDAO Instance
        {
            get { if (instance == null) instance = new BillInforDAO();
                return BillInforDAO.instance; }
            set { BillInforDAO.instance = value; }
        }
        
        public List<billInfor> getListBillInfor(int id)
        {
            List<billInfor> list = new List<billInfor>();
            DataTable dataTable = new DataTable();
            string querry = "SELECT food.name, dbo.FOOD.FoodPrice, dbo.BILLINFOR.count FROM dbo.BILL, dbo.BILLINFOR, dbo.FOOD WHERE bill.idBILL = dbo.BILLINFOR.idBILL AND dbo.BILLINFOR.idFOOD = dbo.FOOD.idFOOD AND dbo.BILl.idTable = " + id;
            dataTable = dataProvider.Instance.excuteQuerry(querry);
            foreach(DataRow item in dataTable.Rows)
            {
                //MessageBox.Show(item["name"].ToString());
                billInfor p = new billInfor(item);
                list.Add(p);
            }
                return list;
        }
    }
}
