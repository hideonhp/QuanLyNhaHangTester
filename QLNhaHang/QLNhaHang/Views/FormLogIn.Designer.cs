namespace QLNhaHang.Views
{
    partial class FormLogIn
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtUsers = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btLoginF1 = new DevExpress.XtraEditors.SimpleButton();
            this.btExitF1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsers.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.hyperlinkLabelControl1);
            this.groupControl1.Controls.Add(this.txtPass);
            this.groupControl1.Controls.Add(this.txtUsers);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(68, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(371, 165);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Đăng Nhập";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(191, 133);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(65, 13);
            this.hyperlinkLabelControl1.TabIndex = 4;
            this.hyperlinkLabelControl1.Text = "Tạo tài khoản";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(179, 76);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(133, 20);
            this.txtPass.TabIndex = 2;
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(179, 41);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(133, 20);
            this.txtUsers.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Chưa có tài khoản ư ?";
            this.labelControl2.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(57, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mật Khẩu:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên Tài Khoản:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // btLoginF1
            // 
            this.btLoginF1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btLoginF1.Location = new System.Drawing.Point(125, 254);
            this.btLoginF1.Name = "btLoginF1";
            this.btLoginF1.Size = new System.Drawing.Size(75, 23);
            this.btLoginF1.TabIndex = 1;
            this.btLoginF1.Text = "Đăng Nhập";
            this.btLoginF1.Click += new System.EventHandler(this.btLoginF1_Click);
            // 
            // btExitF1
            // 
            this.btExitF1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExitF1.Location = new System.Drawing.Point(293, 254);
            this.btExitF1.Name = "btExitF1";
            this.btExitF1.Size = new System.Drawing.Size(75, 23);
            this.btExitF1.TabIndex = 2;
            this.btExitF1.Text = "Thoát";
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 331);
            this.Controls.Add(this.btExitF1);
            this.Controls.Add(this.btLoginF1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsers.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btLoginF1;
        private DevExpress.XtraEditors.SimpleButton btExitF1;
        public DevExpress.XtraEditors.TextEdit txtUsers;
        public DevExpress.XtraEditors.TextEdit txtPass;
    }
}