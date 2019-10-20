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
using System.Globalization;

namespace QuanLiNhaHang_Ver4
{
    public partial class fManagers : Form
    {
        public fManagers()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }
        #region Method
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status ;
                btn.Click += Btn_Click;
                btn.Tag = item;

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
        void ShowBill(int id)
        {

            lvsBill.Items.Clear();
            List<QuanLiNhaHang_Ver4.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLiNhaHang_Ver4.DTO.Menu item in listBillInfo)
            {

                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lvsBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalP.Text = totalPrice.ToString("c",culture);
        }

        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvsBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

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
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByID(id);

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

        private void btAdd_Click(object sender, EventArgs e)
        {
            Table table = lvsBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)numericFood.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);
        }
    }
}
