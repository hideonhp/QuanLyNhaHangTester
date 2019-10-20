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

namespace QuanLyNhaHang_NewVersion
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        List<string> list_detail;
        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào User có ID là: " + FormDangNhap.ID_USER);
            list_detail = cla_crud.list_per(cla_crud.id_per(FormDangNhap.ID_USER));
        }

        private void btKiemTraQuyenHan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang thuộc nhóm quyền lực số:" + cla_crud.id_per(FormDangNhap.ID_USER));
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc là muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc là muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTab(UserControl uct, byte typeCon, String tenTab)
        {
            for (int i=0; i<tabHienThi.TabPages.Count;i++)
            {
                if(tabHienThi.TabPages[i].Contains(uct)==true)
                {
                    tabHienThi.SelectedTab = tabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeCon);
            tab.Name = uct.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = tenTab;
            tabHienThi.TabPages.Add(tab);
            tabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        public void DongTab()
        {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTab);
        }
        public void DongAllTab()
        {
            while(tabHienThi.TabPages.Count>0)
            {
                DongTab();
            }
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTab(UserControlNhanVien.uctNV, 4, "Quản Lí Nhân Viên");
        }

        private void đóngTrangHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void đóngTấtCảCácTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }
    }
}
