using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.Other
{
    public partial class ChangeTable : Form
    {
        private int idTable;
        FlowLayoutPanel change_flp;
        public ChangeTable()
        {
            InitializeComponent();
        }
        public ChangeTable(int idTable = 0, FlowLayoutPanel flp = null)
        {
            InitializeComponent();
            this.idTable = idTable;
            this.change_flp = flp;
            string querry = "SELECT name FROM TABLESTORE";
            DataTable pData1 = dataProvider.Instance.excuteQuerry(querry);
            DataTable pData2 = dataProvider.Instance.excuteQuerry(querry);
            comboBox1.DataSource = pData1;
            comboBox2.DataSource = pData2;
            comboBox1.DisplayMember = "name";
            comboBox2.DisplayMember = "name";
            querry += (" WHERE idTABLE = " + idTable);
            comboBox1.Text = dataProvider.Instance.excuteScalar(querry).ToString();
        }

        private void ThanhToan(int idTable)
        {
            string querry = "SELECT * FROM TABLESTORE WHERE idTABLE = " + idTable + " AND isGood = 0";
            int test = dataProvider.Instance.excuteExist(querry);
            if (test > 0)
                if(MessageBox.Show("Bạn có muốn Thanh toán "
                + "bàn " + comboBox2.Text + "không?", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                dataProvider.Instance.excuteQuerry("UPDATE TABLESTORE SET isGood = 1 WHERE idTABLE = " + idTable);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentIdTable = (int)dataProvider.Instance.excuteFirstElement("SELECT idTABLE FROM TABLESTORE WHERE name = N'" +
                comboBox1.Text + "' AND isGood = 0", "idTABLE");
            int targetIdTable = (int)dataProvider.Instance.excuteFirstElement("SELECT idTABLE FROM TABLESTORE WHERE name = N'" +
                comboBox2.Text + "'", "idTABLE");
            ThanhToan(targetIdTable);
            dataProvider.Instance.excuteQuerry(
                        "UPDATE dbo.BILL SET idTable = " + targetIdTable + " WHERE idTable = " + currentIdTable + " " +
                        "UPDATE TABLESTORE SET isGood = 1 WHERE idTABLE = " + currentIdTable + " " +
                        "UPDATE TABLESTORE SET isGood = 0 WHERE idTABLE = " + targetIdTable);
            foreach(Button btnTable in change_flp.Controls)
            {
                if((btnTable.Tag as TableDTO).Id == currentIdTable)
                {
                    btnTable.BackColor = Color.Aqua;
                    btnTable.Text = "      " + comboBox1.Text + "\n" + ("Trống");
                }
                else if((btnTable.Tag as TableDTO).Id == targetIdTable)
                {
                    btnTable.BackColor = Color.MediumOrchid;
                    btnTable.Text = "      " + comboBox2.Text + "\n" + ("  Có người");
                }
            }

        }
    }
}
