﻿namespace QLNhaHang
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgNani1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btLogIn = new DevExpress.XtraBars.BarButtonItem();
            this.btChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btAccountType = new DevExpress.XtraBars.BarButtonItem();
            this.btBackUp = new DevExpress.XtraBars.BarButtonItem();
            this.btRestore = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbStatus = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabHienThi = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNani1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.imgNani1;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btLogIn,
            this.btChangePass,
            this.btLogOut,
            this.btAccountType,
            this.btBackUp,
            this.btRestore,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1080, 143);
            this.ribbonControl1.StatusBar = this.rbStatus;
            // 
            // imgNani1
            // 
            this.imgNani1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgNani1.ImageStream")));
            this.imgNani1.Images.SetKeyName(0, "005-id card.png");
            this.imgNani1.Images.SetKeyName(1, "010-login.png");
            this.imgNani1.Images.SetKeyName(2, "013-logout.png");
            this.imgNani1.Images.SetKeyName(3, "004-enter.png");
            this.imgNani1.Images.SetKeyName(4, "012-logout.png");
            this.imgNani1.Images.SetKeyName(5, "017-user.png");
            this.imgNani1.Images.SetKeyName(6, "001-browser.png");
            // 
            // btLogIn
            // 
            this.btLogIn.Caption = "Đăng nhập";
            this.btLogIn.Id = 1;
            this.btLogIn.ImageOptions.ImageIndex = 2;
            this.btLogIn.Name = "btLogIn";
            // 
            // btChangePass
            // 
            this.btChangePass.Caption = "Đổi mật khẩu";
            this.btChangePass.Id = 2;
            this.btChangePass.ImageOptions.ImageIndex = 0;
            this.btChangePass.Name = "btChangePass";
            // 
            // btLogOut
            // 
            this.btLogOut.Caption = "Đăng xuất";
            this.btLogOut.Id = 3;
            this.btLogOut.ImageOptions.ImageIndex = 1;
            this.btLogOut.Name = "btLogOut";
            // 
            // btAccountType
            // 
            this.btAccountType.Caption = "Loại tài khoản";
            this.btAccountType.Id = 4;
            this.btAccountType.ImageOptions.ImageIndex = 5;
            this.btAccountType.Name = "btAccountType";
            this.btAccountType.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btBackUp
            // 
            this.btBackUp.Caption = "Sao lưu dữ liệu";
            this.btBackUp.Id = 5;
            this.btBackUp.ImageOptions.ImageIndex = 3;
            this.btBackUp.Name = "btBackUp";
            // 
            // btRestore
            // 
            this.btRestore.Caption = "Phục hồi dữ liệu";
            this.btRestore.Id = 6;
            this.btRestore.ImageOptions.ImageIndex = 3;
            this.btRestore.Name = "btRestore";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 7;
            this.skinRibbonGalleryBarItem1.ImageOptions.ImageIndex = 6;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btLogIn);
            this.ribbonPageGroup1.ItemLinks.Add(this.btChangePass);
            this.ribbonPageGroup1.ItemLinks.Add(this.btLogOut);
            this.ribbonPageGroup1.ItemLinks.Add(this.btAccountType);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btBackUp);
            this.ribbonPageGroup4.ItemLinks.Add(this.btRestore);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Dữ liệu";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Giao Diện";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lí";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Trợ giúp";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // rbStatus
            // 
            this.rbStatus.Location = new System.Drawing.Point(1, 384);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Ribbon = this.ribbonControl1;
            this.rbStatus.Size = new System.Drawing.Size(1074, 27);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // tabHienThi
            // 
            this.tabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHienThi.Location = new System.Drawing.Point(0, 143);
            this.tabHienThi.Name = "tabHienThi";
            this.tabHienThi.Size = new System.Drawing.Size(1080, 415);
            this.tabHienThi.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 558);
            this.Controls.Add(this.tabHienThi);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.rbStatus;
            this.Text = "Quản Lý Nhà Hàng BoDoiNhatHeMatTroi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNani1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraTab.XtraTabControl tabHienThi;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rbStatus;
        private DevExpress.XtraBars.BarButtonItem btLogIn;
        private DevExpress.XtraBars.BarButtonItem btChangePass;
        private DevExpress.XtraBars.BarButtonItem btLogOut;
        private DevExpress.XtraBars.BarButtonItem btAccountType;
        private DevExpress.XtraBars.BarButtonItem btBackUp;
        private DevExpress.XtraBars.BarButtonItem btRestore;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.Utils.ImageCollection imgNani1;
    }
}
