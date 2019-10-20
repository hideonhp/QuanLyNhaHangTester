namespace QuanLiNhaHang_Ver4
{
    partial class fManagers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvsBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btSwichTable = new System.Windows.Forms.Button();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btGiamGia = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.numericFood = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCatoga = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            this.btGiamGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpTable);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 441);
            this.panel1.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(3, 4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(455, 434);
            this.flpTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thôngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // thôngToolStripMenuItem
            // 
            this.thôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngToolStripMenuItem.Name = "thôngToolStripMenuItem";
            this.thôngToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.thôngToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvsBill);
            this.panel2.Location = new System.Drawing.Point(479, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 314);
            this.panel2.TabIndex = 1;
            // 
            // lvsBill
            // 
            this.lvsBill.HideSelection = false;
            this.lvsBill.Location = new System.Drawing.Point(3, 3);
            this.lvsBill.Name = "lvsBill";
            this.lvsBill.Size = new System.Drawing.Size(349, 308);
            this.lvsBill.TabIndex = 0;
            this.lvsBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.btSwichTable);
            this.panel3.Controls.Add(this.numGiamGia);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btThanhToan);
            this.panel3.Location = new System.Drawing.Point(479, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 56);
            this.panel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btSwichTable
            // 
            this.btSwichTable.Location = new System.Drawing.Point(3, 3);
            this.btSwichTable.Name = "btSwichTable";
            this.btSwichTable.Size = new System.Drawing.Size(82, 22);
            this.btSwichTable.TabIndex = 6;
            this.btSwichTable.Text = "Chuyển Bàn";
            this.btSwichTable.UseVisualStyleBackColor = true;
            // 
            // numGiamGia
            // 
            this.numGiamGia.Location = new System.Drawing.Point(181, 31);
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(77, 20);
            this.numGiamGia.TabIndex = 5;
            this.numGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giảm Giá";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(264, 3);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(82, 48);
            this.btThanhToan.TabIndex = 3;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            // 
            // btGiamGia
            // 
            this.btGiamGia.Controls.Add(this.btAdd);
            this.btGiamGia.Controls.Add(this.numericFood);
            this.btGiamGia.Controls.Add(this.cbFood);
            this.btGiamGia.Controls.Add(this.cbCatoga);
            this.btGiamGia.Location = new System.Drawing.Point(479, 27);
            this.btGiamGia.Name = "btGiamGia";
            this.btGiamGia.Size = new System.Drawing.Size(355, 59);
            this.btGiamGia.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(180, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(82, 48);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Thêm Món Ăn";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // numericFood
            // 
            this.numericFood.Location = new System.Drawing.Point(268, 5);
            this.numericFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericFood.Name = "numericFood";
            this.numericFood.Size = new System.Drawing.Size(77, 20);
            this.numericFood.TabIndex = 2;
            this.numericFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(4, 31);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(170, 21);
            this.cbFood.TabIndex = 0;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbCatoga_SelectedIndexChanged);
            // 
            // cbCatoga
            // 
            this.cbCatoga.FormattingEnabled = true;
            this.cbCatoga.Location = new System.Drawing.Point(4, 4);
            this.cbCatoga.Name = "cbCatoga";
            this.cbCatoga.Size = new System.Drawing.Size(170, 21);
            this.cbCatoga.TabIndex = 0;
            this.cbCatoga.SelectedIndexChanged += new System.EventHandler(this.cbCatoga_SelectedIndexChanged);
            // 
            // fManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 480);
            this.Controls.Add(this.btGiamGia);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fManagers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lí Nhà Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fManagers_FormClosing);
            this.Load += new System.EventHandler(this.fManagers_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            this.btGiamGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvsBill;
        private System.Windows.Forms.Panel btGiamGia;
        private System.Windows.Forms.ComboBox cbCatoga;
        private System.Windows.Forms.NumericUpDown numericFood;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btSwichTable;
        private System.Windows.Forms.NumericUpDown numGiamGia;
    }
}