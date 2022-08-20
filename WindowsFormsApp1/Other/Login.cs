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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
                /*if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // if (Login(txtUser.Text.ToLower(), txtPassWord.Text.ToLower()))
            //{
            Login(txtUser.Text, txtPassWord.Text);
                Table pTable = new Table();
                this.Hide();
                pTable.ShowDialog();
                this.Show();
           /* }
            else
            {
                MessageBox.Show("Sai Tài Khoản Mật Khẩu");
            }*/
        }

        bool Login(string userName, string Password)
        {
            return AccountDAO.Instance.Login(userName, Password);
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
