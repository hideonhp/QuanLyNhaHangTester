using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Windows;
using QLNhaHang.Views;
using System.Data.SqlClient;
namespace QLNhaHang
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            DisEnd(true, idLogIn);
        }
        public static string user;
        public static string idLogIn;

        //internal static List<byte> typePages = new List<byte>();
        //public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        //{
        //    //Kiểm tra tồn tại trang này chưa
        //    for (int i=0; i<tabHienThi.TabPages.Count;i++)
        //    {
        //        if (tabHienThi.TabPages[i].Contains(uct)==true)
        //        {
        //            tabHienThi.SelectedTabPage = tabHienThi.TabPages[i];
        //            return;
        //        }
        //    }
        //    TabPage tab = new TabPage();
        //    typePages.Add(typeControl);
        //    tab.Name = uct.Name;
        //    tab.Size = tabHienThi.Size;
        //    tab.Text = tenTab;
        //    tabHienThi.TabPages.Add(tab);
        //    tabHienThi.SelectedTabPage = tab;
        //    uct.Dock = DockStyle.Fill;
        //    tab.Controls.Add(uct);
        //    uct.Focus();
        //}
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "DevExpress Dark Style";
        }
        //ẩn mấy cái không cần thiết cho đến khi đăng nhập
        public void DisEnd(bool e, string _idLogIn)
        {
            btLogIn.Enabled = e;
            btChangePass.Enabled = !e;
            btLogOut.Enabled = !e;
            btAccountType.Enabled = !e;
            btBackUp.Enabled = !e;
            btRestore.Enabled = !e;
            btKetCa.Enabled = !e;
            barStaticItem1.Enabled = !e;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có chắc là muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btLogIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLogIn logIn = null;
            //Khi mà ko có tk hay mk thì check login sẽ tự động khởi động lại form
            Check_Login:
            if (logIn == null || logIn.IsDisposed)
                logIn = new FormLogIn();
            if (logIn.ShowDialog()==DialogResult.OK)
            {
                if (logIn.txtUsers.Text =="")
                {
                    XtraMessageBox.Show("Không có tài khoản mà đòi đăng nhập à ?");
                    goto Check_Login;
                }
                if (logIn.txtPass.Text =="")
                {
                    XtraMessageBox.Show("Không có mật khẩu mà đòi đăng nhập à ?");
                    goto Check_Login;
                }
                string check = "";
                user = logIn.txtUsers.Text;
                //gọi hàm sha 265 mã hóa mật khẩu cho pro
                string pass = Models.Pass265.SHA256(logIn.txtPass.Text);
                check = Control.LogInCtrl.CheckDangNhap(user, pass);
                if(check == "")
                {
                    XtraMessageBox.Show("Đăng nhập thất bại. Có gì đó sai sai, kiểm tra lại đi !");
                    goto Check_Login;
                }
                else
                {
                    DisEnd(false, idLogIn);
                        barStaticItem1.Caption = "Bạn đang đăng nhập với quyền Admin";
                }
            }
        }

        private void btLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Đăng xuất thành công", "Cảnh báo", MessageBoxButtons.OK) == DialogResult.OK);
            {
                DisEnd(true, idLogIn);
                btLogIn_ItemClick(sender, e);
            }
        }

        private void btChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChange fc = new FormChange();
            fc.ShowDialog();
        }

        private void tabHienThi_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable asd = new DataTable();    
            using (SqlConnection sqlConzz = new SqlConnection(connectionString:))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM QuanLyNhanVien", sqlConzz))
                {
                    sqlConzz.Open();
                    SqlDataReader readera = cmd.ExecuteReader();
                    asd.Load(reader:);
                }
            }
            return asd;
        }
    }
    
}
