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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThemHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemSach = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribHoaDon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage8 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDSDVT = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThemHD,
            this.btnDSHD,
            this.btnThemSach,
            this.barButtonItem1,
            this.btnDSDVT});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribHoaDon,
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6,
            this.ribbonPage7,
            this.ribbonPage8});
            this.ribbon.Size = new System.Drawing.Size(921, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Caption = "Thêm Hóa Đơn";
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
            // ribHoaDon
            // 
            this.ribHoaDon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("ribHoaDon.Image")));
            this.ribHoaDon.Name = "ribHoaDon";
            this.ribHoaDon.Text = "Hóa Đơn";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThemHD);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSHD);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Sách";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThemSach);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "VPP";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "NCC";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ĐVT";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Chi Phí";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage6.Image")));
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "HĐ Nhập";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage7.Image")));
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "Phiếu Nhập";
            // 
            // ribbonPage8
            // 
            this.ribbonPage8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage8.Image")));
            this.ribbonPage8.Name = "ribbonPage8";
            this.ribbonPage8.Text = "Loại Sách";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 497);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(921, 31);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSDVT);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 168);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(921, 332);
            this.xtraTabControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 528);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnThemHD;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btnDSHD;
        private DevExpress.XtraBars.BarButtonItem btnThemSach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage8;
        private DevExpress.XtraBars.BarButtonItem btnDSDVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    }
}