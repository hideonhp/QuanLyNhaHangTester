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
namespace QLNhaHang
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
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
    }
    
}
