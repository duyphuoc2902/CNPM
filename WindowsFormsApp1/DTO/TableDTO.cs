using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class TableDTO
    {
        public TableDTO() { }
        public TableDTO(int a, string b, int c)
        {
            id = a;
            Name = b;
            Status = c;
        }
        public TableDTO(DataRow p)
        {
            Id = (int)p["idTABLE"];
            Name = p["name"].ToString();
            Status = (int)p["isGood"];
        }

        private string name;
        public string Name {
             get { return name; } set { name = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
