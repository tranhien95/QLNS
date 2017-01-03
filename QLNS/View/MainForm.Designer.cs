namespace QLNS.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThemHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemSach = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDVT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribHoaDon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribSanPham = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribNCC = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribDVT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribChiPhi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribPhieuNhap = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribLoaiSach = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtcHDBH = new DevExpress.XtraTab.XtraTabControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcHDBH)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThemHD,
            this.btnDSHD,
            this.btnThemSach,
            this.barButtonItem1,
            this.btnDSDVT,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barDockingMenuItem1,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnDoiMK,
            this.barButtonItem7,
            this.btnDSTK,
            this.btnThemTK,
            this.barButtonItem10,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribHoaDon,
            this.ribSanPham,
            this.ribChiPhi,
            this.ribPhieuNhap,
            this.ribBaoCao,
            this.ribLoaiSach,
            this.ribNCC,
            this.ribDVT,
            this.ribTaiKhoan});
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(924, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Caption = "Thêm Mới";
            this.btnThemHD.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThemHD.Glyph")));
            this.btnThemHD.Id = 1;
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThemHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnDSHD
            // 
            this.btnDSHD.Caption = "Danh Sách Hóa Đơn";
            this.btnDSHD.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSHD.Glyph")));
            this.btnDSHD.Id = 2;
            this.btnDSHD.Name = "btnDSHD";
            this.btnDSHD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Caption = "Thêm Sách Mới";
            this.btnThemSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThemSach.Glyph")));
            this.btnThemSach.Id = 3;
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh Mục Sach";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDSDVT
            // 
            this.btnDSDVT.Caption = "Danh Sách ĐVT";
            this.btnDSDVT.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSDVT.Glyph")));
            this.btnDSDVT.Id = 5;
            this.btnDSDVT.Name = "btnDSDVT";
            this.btnDSDVT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDSDVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDVT_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm VPP";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Danh Mục VPP";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
            this.barDockingMenuItem1.Id = 8;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Glyph")));
            this.btnDangNhap.Id = 10;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 11;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi Mật Khẩu";
            this.btnDoiMK.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Glyph")));
            this.btnDoiMK.Id = 12;
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnDSTK
            // 
            this.btnDSTK.Caption = "Danh Sách Tài Khoản";
            this.btnDSTK.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSTK.Glyph")));
            this.btnDSTK.Id = 14;
            this.btnDSTK.Name = "btnDSTK";
            this.btnDSTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Caption = "Thêm Tài Khoản";
            this.btnThemTK.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThemTK.Glyph")));
            this.btnThemTK.Id = 15;
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Danh Sách HĐ";
            this.barButtonItem10.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.Glyph")));
            this.barButtonItem10.Id = 16;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribHoaDon
            // 
            this.ribHoaDon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup7});
            this.ribHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("ribHoaDon.Image")));
            this.ribHoaDon.Name = "ribHoaDon";
            this.ribHoaDon.Text = "Hóa Đơn";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThemHD);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hóa Đơn Bán Hàng";
            // 
            // ribSanPham
            // 
            this.ribSanPham.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribSanPham.Image = ((System.Drawing.Image)(resources.GetObject("ribSanPham.Image")));
            this.ribSanPham.Name = "ribSanPham";
            this.ribSanPham.Text = "Sản Phẩm";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThemSach);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Sách";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Sản Phẩm";
            // 
            // ribNCC
            // 
            this.ribNCC.Image = ((System.Drawing.Image)(resources.GetObject("ribNCC.Image")));
            this.ribNCC.Name = "ribNCC";
            this.ribNCC.Text = "NCC";
            // 
            // ribDVT
            // 
            this.ribDVT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribDVT.Image = ((System.Drawing.Image)(resources.GetObject("ribDVT.Image")));
            this.ribDVT.Name = "ribDVT";
            this.ribDVT.Text = "ĐVT";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSDVT);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribChiPhi
            // 
            this.ribChiPhi.Image = ((System.Drawing.Image)(resources.GetObject("ribChiPhi.Image")));
            this.ribChiPhi.Name = "ribChiPhi";
            this.ribChiPhi.Text = "Chi Phí";
            // 
            // ribPhieuNhap
            // 
            this.ribPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("ribPhieuNhap.Image")));
            this.ribPhieuNhap.Name = "ribPhieuNhap";
            this.ribPhieuNhap.Text = "Phiếu Nhập";
            // 
            // ribLoaiSach
            // 
            this.ribLoaiSach.Image = ((System.Drawing.Image)(resources.GetObject("ribLoaiSach.Image")));
            this.ribLoaiSach.Name = "ribLoaiSach";
            this.ribLoaiSach.Text = "Loại Sách";
            // 
            // ribTaiKhoan
            // 
            this.ribTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("ribTaiKhoan.Image")));
            this.ribTaiKhoan.Name = "ribTaiKhoan";
            this.ribTaiKhoan.Text = "User";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDoiMK);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDSTK);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnThemTK);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 489);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(924, 31);
            // 
            // xtcHDBH
            // 
            this.xtcHDBH.Appearance.BackColor = System.Drawing.Color.Silver;
            this.xtcHDBH.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xtcHDBH.Appearance.BorderColor = System.Drawing.Color.Black;
            this.xtcHDBH.Appearance.Options.UseBackColor = true;
            this.xtcHDBH.Appearance.Options.UseBorderColor = true;
            this.xtcHDBH.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtcHDBH.Location = new System.Drawing.Point(0, 168);
            this.xtcHDBH.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.xtcHDBH.Name = "xtcHDBH";
            this.xtcHDBH.Size = new System.Drawing.Size(921, 320);
            this.xtcHDBH.TabIndex = 2;
            this.xtcHDBH.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            this.xtcHDBH.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.xtraTabControl1_ControlAdded);
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Hóa Đơn Nhập Hàng";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thêm Mới";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 17;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Danh Sách HĐ Nhập";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribBaoCao
            // 
            this.ribBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("ribBaoCao.Image")));
            this.ribBaoCao.Name = "ribBaoCao";
            this.ribBaoCao.Text = "Báo Cáo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 520);
            this.Controls.Add(this.xtcHDBH);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcHDBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnThemHD;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribSanPham;
        private DevExpress.XtraBars.BarButtonItem btnDSHD;
        private DevExpress.XtraBars.BarButtonItem btnThemSach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribNCC;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDVT;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribChiPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPhieuNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribLoaiSach;
        private DevExpress.XtraBars.BarButtonItem btnDSDVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTab.XtraTabControl xtcHDBH;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnDSTK;
        private DevExpress.XtraBars.BarButtonItem btnThemTK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBaoCao;
    }
}