using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.Other;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
            load_table();
            LoadFoodType();
        }

        private Button Old_Button;

        private int idTable = 1; // table num which are selected

        private string currentTableName;

        private int table_weight = 100, table_height = 100;


        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccount pUser = new UserAccount();
            pUser.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAccount pAdmin = new AdminAccount();
            this.Hide();
            pAdmin.ShowDialog();
            this.Show();
        }

        public bool checkExist()
        {
            return true;
        }

        void load_table()
        {
            foreach (Control control in fplTable.Controls)
            {
                fplTable.Controls.Remove(control);
                control.Dispose();
            }
            List<TableDTO> TableList = TableDAO.Instance.Tablelist_load();
            foreach (TableDTO Table in TableList)
            {
                Button btnTable = new Button() { Width = table_weight, Height = table_height };
                btnTable.Text = "      " + Table.Name + "\n" + (Table.Status == 0 ? " Có người" : "Trống");
                currentTableName = Table.Name;
                btnTable.Tag = Table;
                btnTable.Click += btn_Click;
                if (Table.Status > 0)
                    btnTable.BackColor = Color.Aqua;
                else
                {
                    btnTable.BackColor = Color.MediumOrchid;
                }
                btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                fplTable.Controls.Add(btnTable);
            }
        }

        public void showBill(int tableID)
        {
            button2.Text = "Lưu";
            listView1.Items.Clear();
            idTable = tableID;
            if (dataProvider.Instance.excuteExist("SELECT * FROM TABLESTORE WHERE idTABLE = " + idTable + " AND isGood = 0") > 0)
            {
                button2.Text = "Thanh Toán";
                List<billInfor> ListBill = BillInforDAO.Instance.getListBillInfor(tableID);
                float TotalPrice = 0;
                foreach (billInfor item in ListBill)
                {
                    ListViewItem lvItem = new ListViewItem(item.Name);
                    lvItem.SubItems.Add(item.Count.ToString());
                    lvItem.SubItems.Add(item.Price.ToString());
                    lvItem.SubItems.Add(item.Discount.ToString());
                    lvItem.SubItems.Add(item.TotalPrice.ToString());
                    TotalPrice += item.TotalPrice;
                    listView1.Items.Add(lvItem);
                }
                CultureInfo culture = new CultureInfo("vi-vn");
                TongTien.Text = TotalPrice.ToString("c", culture);
            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableDTO).Id;
            //MessageBox.Show(tableID.ToString());
            if (Old_Button != null)
                Old_Button.FlatAppearance.BorderColor = Color.White;
            Button p = sender as Button;
            Old_Button = p;
            p.FlatStyle = FlatStyle.Flat;
            p.FlatAppearance.BorderColor = Color.Red;
            p.FlatAppearance.BorderSize = 2;
            showBill(tableID);
        }

        int getCurrentIdTable()
        {
            return idTable;
        }

        void LoadFoodType()
        {
            string querry = "SELECT name FROM dbo.FOODTYPE";
            DataTable pData = dataProvider.Instance.excuteQuerry(querry);
            /*foreach (DataRow row in pData.Rows)
            {
                cbbFoodType.Items.Add(row["name"].ToString());
            }*/
            cbbFoodType.DataSource = pData;
            cbbFoodType.DisplayMember = "Name";
        }

        public int isBilled(int id)
        {
            return BillDAO.Instance.getBillIDbyTableID(id);
        }

        private void cbbFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFood();
        }


        private void ThemMon_Click(object sender, EventArgs e)
        {

            if (isBilled(idTable) == -1)
            {
                 if (FoodCount.Value > 0)
                 {
                    string querry = "INSERT INTO dbo.BILL (Time, idTable) VALUES (GETDATE(), " + idTable + ")  ";
                    querry += ("UPDATE dbo.TABLESTORE SET isGood = 0 WHERE idTABLE = " + idTable + " ");
                    Old_Button.BackColor = Color.MediumOrchid;
                    Old_Button.Text = "      " + currentTableName + "\n" + "Có Người";
                    dataProvider.Instance.excuteQuerry(querry);
                    string querryIdBill = "SELECT TOP 1 Bill.idBILL FROM dbo.BILL WHERE idTable = " + idTable + " ORDER BY idBILL DESC";
                    string querryIdFood = "SELECT idFOOD FROM dbo.FOOD WHERE food.name = N'" + cbbFood.Text + "'";

                    DataTable IdBill = dataProvider.Instance.excuteQuerry(querryIdBill);
                    DataTable IdFood = dataProvider.Instance.excuteQuerry(querryIdFood);

                    int idBill = 0, idFood = 0;

                    foreach (DataRow row in IdBill.Rows)
                    {
                        idBill = (int)row["idBILL"];
                    }

                    foreach (DataRow row in IdFood.Rows)
                    {
                        idFood = (int)row["idFOOD"];
                    }

                    //MessageBox.Show(cbbFood.Text);
                    querry = ("INSERT INTO dbo.BILLINFOR(Time, idBILL, idFOOD, count) VALUES(GETDATE(), " + idBill + "," + idFood + "," + FoodCount.Value + ") ");
                    dataProvider.Instance.excuteQuerry(querry);
                 }
            }
            else
            {
                if (FoodCount.Value > 0)
                {
                    string querryIdBill = "SELECT TOP 1 Bill.idBILL FROM dbo.BILL WHERE idTable = " + idTable + " ORDER BY idBILL DESC";
                    string querryIdFood = "SELECT idFOOD FROM dbo.FOOD WHERE food.name = N'" + cbbFood.Text + "'";

                    DataTable IdBill = dataProvider.Instance.excuteQuerry(querryIdBill);
                    DataTable IdFood = dataProvider.Instance.excuteQuerry(querryIdFood);
                    int idBill = 0, idFood = 0;

                    foreach (DataRow row in IdBill.Rows)
                    {
                        idBill = (int)row["idBILL"];
                    }

                    foreach (DataRow row in IdFood.Rows)
                    {
                        idFood = (int)row["idFOOD"];
                    }

                    string querryNumFood = "SELECT * FROM dbo.BILLINFOR WHERE idFOOD = " + idFood + " AND idBILL = " + idBill;
                    DataTable pdata = dataProvider.Instance.excuteQuerry(querryNumFood);
                    string querry = "";
                    if(pdata.Rows.Count > 0)
                        querry = "UPDATE dbo.BILLINFOR SET count = Count + " + FoodCount.Value + " WHERE idBILL = " + idBill + " AND idFOOD = " + idFood;
                    else
                    {
                        querry = "INSERT dbo.BILLINFOR(Time, idBILL, idFOOD, count) VALUES (GETDATE(), " + idBill + ", " + idFood + ", " + FoodCount.Value + ")";
                    }
                    string result = "id bill: " + idBill + ", id food: " + idFood + ", num " + FoodCount.Value + ", num2: " + pdata.Rows.Count + ", food: " + cbbFood.Text + " , id food: " + idFood;
                    dataProvider.Instance.excuteQuerry(querry);
                }
            }
                showBill(idTable);
            
        }

        void LoadFood()
        {
            string querry = "SELECT food.name FROM dbo.FOOD, dbo.FOODTYPE WHERE food.idFOODTYPE = dbo.FOODTYPE.idFOODTYPE AND dbo.FOODTYPE.name = N'" + cbbFoodType.Text + "'";
            DataTable pData = dataProvider.Instance.excuteQuerry(querry);
            cbbFood.DataSource = pData;
            cbbFood.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           ThanhToan();
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            ChangeTable pChangeTable = new ChangeTable(idTable, fplTable);
            pChangeTable.Show();
        }

        public void load_FoodTable()
        {
            fplTable.Controls.Clear();
            List<FoodDTO> FoodList = FoodDAOcs.Instance.Foodlist_load();
            foreach (FoodDTO Food in FoodList)
            {
                Button btnFood = new Button() { Width = table_weight, Height = table_height };
                btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnFood.Text = Food.FoodName;
                btnFood.Tag = Food;
                btnFood.Click += btnFood_click;
                btnFood.BackColor = Color.Aqua;
                fplTable.Controls.Add(btnFood);
            }
        }

        private void btnFood_click(object sender, EventArgs e)
        {
            FoodDTO Food = (sender as Button).Tag as FoodDTO;
            cbbFoodType.Text = Food.FoodType;
            cbbFood.Text = Food.FoodName;
            ThemMon_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fplTable.Controls.Clear();
            load_table();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_FoodTable();
        }

        public void ThanhToan()
        {
            string querry = "SELECT * FROM TABLESTORE WHERE idTABLE = " + idTable + " AND isGood = 0";
            int test = dataProvider.Instance.excuteExist(querry);
            if (test > 0 && MessageBox.Show("Bạn có muốn Thanh toán không?", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                dataProvider.Instance.excuteQuerry("UPDATE TABLESTORE SET isGood = 1 WHERE idTABLE = " + idTable);
                Old_Button.BackColor = Color.Aqua;
                Old_Button.Text = "      " + currentTableName + "\n" + "Trống";
                button2.Text = "Lưu";
                listView1.Items.Clear();
            }
            
        }
    }
}
