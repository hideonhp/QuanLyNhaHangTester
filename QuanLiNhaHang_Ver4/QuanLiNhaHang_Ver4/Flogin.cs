using QuanLiNhaHang_Ver4.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang_Ver4
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc là muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string pass = txtPass.Text;
            if (Login(username,pass))
            {
                fManagers f = new fManagers();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
            }
        }
        bool Login(string username, string pass)
        {
            return AccountDAO.Instance.Login(username, pass);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
