namespace QLNS.View
{
    partial class ThemMoiPhieuNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.gdcDsMatHang = new DevExpress.XtraGrid.GridControl();
            this.gvDsMatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcDsMatHangDaChon = new DevExpress.XtraGrid.GridControl();
            this.gvDsMatHangDaChon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblChiPhiUocTinh = new DevExpress.XtraEditors.LabelControl();
            this.lblNgayLap = new DevExpress.XtraEditors.LabelControl();
            this.lblMaPhieuNhap = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDsMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDsMatHangDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsMatHangDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cbbNCC);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnLapPhieuNhap);
            this.panelControl1.Controls.Add(this.gdcDsMatHang);
            this.panelControl1.Controls.Add(this.gdcDsMatHangDaChon);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1294, 469);
            this.panelControl1.TabIndex = 5;
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(100, 49);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(121, 21);
            this.cbbNCC.TabIndex = 7;
            this.cbbNCC.SelectionChangeCommitted += new System.EventHandler(this.cbbNCC_SelectionChangeCommitted);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(472, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(48, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(472, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(48, 37);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLapPhieuNhap
            // 
            this.btnLapPhieuNhap.Location = new System.Drawing.Point(884, 389);
            this.btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            this.btnLapPhieuNhap.Size = new System.Drawing.Size(94, 34);
            this.btnLapPhieuNhap.TabIndex = 5;
            this.btnLapPhieuNhap.Text = "Lập phiếu nhập";
            this.btnLapPhieuNhap.Click += new System.EventHandler(this.btnLapPhieuNhap_Click);
            // 
            // gdcDsMatHang
            // 
            this.gdcDsMatHang.Location = new System.Drawing.Point(5, 154);
            this.gdcDsMatHang.MainView = this.gvDsMatHang;
            this.gdcDsMatHang.Name = "gdcDsMatHang";
            this.gdcDsMatHang.Size = new System.Drawing.Size(461, 200);
            this.gdcDsMatHang.TabIndex = 4;
            this.gdcDsMatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDsMatHang});
            // 
            // gvDsMatHang
            // 
            this.gvDsMatHang.GridControl = this.gdcDsMatHang;
            this.gvDsMatHang.Name = "gvDsMatHang";
            // 
            // gdcDsMatHangDaChon
            // 
            this.gdcDsMatHangDaChon.Location = new System.Drawing.Point(526, 154);
            this.gdcDsMatHangDaChon.MainView = this.gvDsMatHangDaChon;
            this.gdcDsMatHangDaChon.Name = "gdcDsMatHangDaChon";
            this.gdcDsMatHangDaChon.Size = new System.Drawing.Size(452, 200);
            this.gdcDsMatHangDaChon.TabIndex = 4;
            this.gdcDsMatHangDaChon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDsMatHangDaChon});
            // 
            // gvDsMatHangDaChon
            // 
            this.gvDsMatHangDaChon.GridControl = this.gdcDsMatHangDaChon;
            this.gvDsMatHangDaChon.Name = "gvDsMatHangDaChon";
            this.gvDsMatHangDaChon.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDsMatHangDaChon_CellValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(526, 110);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(163, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Danh sách các mặt hàng đặt mua:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Các mặt hàng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nhà cung cấp:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.lblChiPhiUocTinh);
            this.panelControl2.Controls.Add(this.lblNgayLap);
            this.panelControl2.Controls.Add(this.lblMaPhieuNhap);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Location = new System.Drawing.Point(987, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(310, 464);
            this.panelControl2.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Chi phí ước tính:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 137);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Ngày lập:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Ngày lập:";
            // 
            // lblChiPhiUocTinh
            // 
            this.lblChiPhiUocTinh.Location = new System.Drawing.Point(144, 137);
            this.lblChiPhiUocTinh.Name = "lblChiPhiUocTinh";
            this.lblChiPhiUocTinh.Size = new System.Drawing.Size(6, 13);
            this.lblChiPhiUocTinh.TabIndex = 2;
            this.lblChiPhiUocTinh.Text = "0";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Location = new System.Drawing.Point(144, 93);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(0, 13);
            this.lblNgayLap.TabIndex = 2;
            // 
            // lblMaPhieuNhap
            // 
            this.lblMaPhieuNhap.Location = new System.Drawing.Point(144, 52);
            this.lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            this.lblMaPhieuNhap.Size = new System.Drawing.Size(18, 13);
            this.lblMaPhieuNhap.TabIndex = 2;
            this.lblMaPhieuNhap.Text = "123";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mã phiếu nhập:";
            // 
            // ThemMoiPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ThemMoiPhieuNhap";
            this.Size = new System.Drawing.Size(1300, 475);
            this.Load += new System.EventHandler(this.ThemMoiPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDsMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDsMatHangDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsMatHangDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gdcDsMatHangDaChon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDsMatHangDaChon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieuNhap;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl lblChiPhiUocTinh;
        private DevExpress.XtraEditors.LabelControl lblNgayLap;
        private DevExpress.XtraEditors.LabelControl lblMaPhieuNhap;
        private System.Windows.Forms.ComboBox cbbNCC;
        private DevExpress.XtraGrid.GridControl gdcDsMatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDsMatHang;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
