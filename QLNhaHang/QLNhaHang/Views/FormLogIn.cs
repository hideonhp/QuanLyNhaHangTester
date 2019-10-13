using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNhaHang.Views;

namespace QLNhaHang.Views
{
    public partial class FormLogIn : DevExpress.XtraEditors.XtraForm
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            txtPass.Properties.PasswordChar = '*';
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            FormCreateAcc Cre = new FormCreateAcc();
            Cre.ShowDialog();
        }

        private void btLoginF1_Click(object sender, EventArgs e)
        {

        }
    }
}