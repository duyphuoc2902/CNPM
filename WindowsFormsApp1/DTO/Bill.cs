using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DTO
{
    internal class Bill
    {
        private int idBill;
        public int IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }
        private DateTime? date;
        public DateTime? Date
        {
            get { return date; }
            set { date = value; }
        }

        public Bill(int id, DateTime Day)
        {
            IdBill = id;
            Date = Day;
        }

        public  Bill(DataRow p)
        {
            IdBill = (int)p["idBILL"];
        }
        
    }
}
