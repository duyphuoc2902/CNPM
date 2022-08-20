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
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
            textBox1.Text = AccountDAO.Instance.getUsername();
            textBox2.Text = dataProvider.Instance.excuteFirstElement("SELECT DisplayName FROM dbo.ACCOUNT WHERE UserName = '" + UserName + "'", "DisplayName").ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserAccount_Load(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.compare(textBox3.Text))
            {
                if(textBox4.Text == textBox5.Text)
                {
                    if(MessageBox.Show("Bạn có muốn đổi mật khẩu không?", 
                        "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK){
                        string querry = "UPDATE dbo.ACCOUNT SET UserPass = "+ textBox4.Text +
                            " WHERE UserName = N'" + textBox1.Text + "'";
                        dataProvider.Instance.excuteQuerry(querry);
                    }
                }
            }
            UserAccount pUser = new UserAccount();
            pUser.ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
