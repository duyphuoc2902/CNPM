using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        public BillDAO() { }

        public int getBillIDbyTableID(int id)
        {
            DataTable data = dataProvider.Instance.excuteQuerry("SELECT idBILL FROM dbo.BILL, dbo.TABLESTORE WHERE Bill.idTable = dbo.TABLESTORE.idTABLE AND bill.idTable = " + id + " AND dbo.TABLESTORE.isGood = 0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.IdBill;
            }
            return -1;
            
        }
    }
}
