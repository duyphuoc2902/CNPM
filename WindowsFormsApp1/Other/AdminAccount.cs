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
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class AdminAccount : Form
    {
        public AdminAccount()
        {
            InitializeComponent();
            load_FoodList();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {

            string querry = "SELECT UserName AS 'Tai Khoan', DisplayName AS 'Họ Tên', Type AS 'Chức Vụ' FROM ACCOUNT";
            string querry2 = "EXEC PRO_GetUserByUserDisplayName @userDisplayName";
            object[] p = new object[] { "admin" };
            dtgvAccount.DataSource = dataProvider.Instance.excuteQuerry(querry2, p);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM ACCOUNT WHERE DisplayName like N'" + txtHoten.Text.ToLower() + "'";
            dtgvAccount.DataSource = dataProvider.Instance.excuteQuerry(querry);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT name as 'Tên món ăn' FROM FOOD WHERE idFOODTYPE = " +
                " (SELECT idFOODTYPE FROM FOODTYPE WHERE name = N'" + cbbFoodType.Text + "')";
            DataTable pData = dataProvider.Instance.excuteQuerry(querry);
            dtgvFood.DataSource = pData;
            comboBox2.DataSource = pData;
            comboBox2.DisplayMember = "Tên món ăn";
            comboBox2.Text = cbbFoodType.Text;
            dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void load_FoodList()
        {
            string querry = "SELECT name FROM FOODTYPE";
            DataTable pData = dataProvider.Instance.excuteQuerry(querry);
            cbbFoodType.DataSource = pData;
            cbbFoodType.DisplayMember = "name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string querry = "INSERT dbo.FOODTYPE (name) VALUES (N" + textBox2.Text + ")";
            dataProvider.Instance.excuteQuerry(querry);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string querry = "DELETE FROM dbo.FOODTYPE WHERE name = N'" + comboBox2.Text + "'";
            dataProvider.Instance.excuteQuerry(querry);
        }
    }
}
