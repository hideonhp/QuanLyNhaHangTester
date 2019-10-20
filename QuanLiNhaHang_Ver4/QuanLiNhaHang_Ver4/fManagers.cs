using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhaHang_Ver4.DTO;
using QuanLiNhaHang_Ver4.DAO;

namespace QuanLiNhaHang_Ver4
{
    public partial class fManagers : Form
    {
        public fManagers()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status ;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.BlueViolet;
                        break;
                    default:
                        btn.BackColor = Color.AliceBlue;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        #endregion

        #region Events

        private void fManagers_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc là muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbCatoga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccProfile f = new fAccProfile();
            f.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fManagers_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
