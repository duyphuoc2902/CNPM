using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        public TableDAO() { }

        public List<TableDTO> Tablelist_load()
        {
            List<TableDTO> list = new List<TableDTO>();
            DataTable data = dataProvider.Instance.excuteQuerry("EXEC  PRO_GetTableFood");
            TableDTO p = new TableDTO();
            foreach(DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                list.Add(table);
            }
            return list;
        }

    }
}
