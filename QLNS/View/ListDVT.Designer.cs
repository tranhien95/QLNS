namespace QLNS.View
{
    partial class ListDVT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDVT));
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.gcDVT = new DevExpress.XtraGrid.GridControl();
            this.gvDVT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDVTF = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbMaSPLe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSoLuongDoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSPLe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSPSi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDVT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDVT1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDVTF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaSPLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSPLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSPSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDVT1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTim.Location = new System.Drawing.Point(417, 111);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(38, 20);
            this.btnTim.TabIndex = 0;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnChiTiet.Location = new System.Drawing.Point(587, 88);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(70, 60);
            this.btnChiTiet.TabIndex = 0;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // gcDVT
            // 
            this.gcDVT.Location = new System.Drawing.Point(206, 158);
            this.gcDVT.MainView = this.gvDVT;
            this.gcDVT.Name = "gcDVT";
            this.gcDVT.Size = new System.Drawing.Size(477, 197);
            this.gcDVT.TabIndex = 1;
            this.gcDVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDVT});
            // 
            // gvDVT
            // 
            this.gvDVT.GridControl = this.gcDVT;
            this.gvDVT.Name = "gvDVT";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(249, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên ĐVT:";
            // 
            // txtTenDVTF
            // 
            this.txtTenDVTF.Location = new System.Drawing.Point(311, 111);
            this.txtTenDVTF.Name = "txtTenDVTF";
            this.txtTenDVTF.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTenDVTF.Size = new System.Drawing.Size(100, 20);
            this.txtTenDVTF.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cbbMaSPLe);
            this.panelControl1.Controls.Add(this.txtSoLuongDoi);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtTenSPLe);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtTenSPSi);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtTenDVT);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtMaDVT1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(689, 76);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(413, 307);
            this.panelControl1.TabIndex = 4;
            // 
            // cbbMaSPLe
            // 
            this.cbbMaSPLe.Location = new System.Drawing.Point(179, 128);
            this.cbbMaSPLe.Name = "cbbMaSPLe";
            this.cbbMaSPLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaSPLe.Size = new System.Drawing.Size(100, 20);
            this.cbbMaSPLe.TabIndex = 4;
            // 
            // txtSoLuongDoi
            // 
            this.txtSoLuongDoi.Location = new System.Drawing.Point(179, 204);
            this.txtSoLuongDoi.Name = "txtSoLuongDoi";
            this.txtSoLuongDoi.Size = new System.Drawing.Size(41, 20);
            this.txtSoLuongDoi.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(96, 207);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Số lượng đổi";
            // 
            // txtTenSPLe
            // 
            this.txtTenSPLe.Location = new System.Drawing.Point(179, 165);
            this.txtTenSPLe.Name = "txtTenSPLe";
            this.txtTenSPLe.Properties.ReadOnly = true;
            this.txtTenSPLe.Size = new System.Drawing.Size(100, 20);
            this.txtTenSPLe.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(96, 168);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Tên SP Lẻ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(96, 131);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Mã SP Lẻ";
            // 
            // txtTenSPSi
            // 
            this.txtTenSPSi.Location = new System.Drawing.Point(179, 91);
            this.txtTenSPSi.Name = "txtTenSPSi";
            this.txtTenSPSi.Properties.ReadOnly = true;
            this.txtTenSPSi.Size = new System.Drawing.Size(159, 20);
            this.txtTenSPSi.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(96, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Tên SP Sỉ:";
            // 
            // txtTenDVT
            // 
            this.txtTenDVT.Location = new System.Drawing.Point(179, 56);
            this.txtTenDVT.Name = "txtTenDVT";
            this.txtTenDVT.Size = new System.Drawing.Size(159, 20);
            this.txtTenDVT.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(96, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên ĐVT:";
            // 
            // txtMaDVT1
            // 
            this.txtMaDVT1.Location = new System.Drawing.Point(179, 21);
            this.txtMaDVT1.Name = "txtMaDVT1";
            this.txtMaDVT1.Properties.ReadOnly = true;
            this.txtMaDVT1.Size = new System.Drawing.Size(41, 20);
            this.txtMaDVT1.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã ĐVT:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnLamMoi.Location = new System.Drawing.Point(494, 88);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(70, 60);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // ListDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txtTenDVTF);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcDVT);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnTim);
            this.Name = "ListDVT";
            this.Size = new System.Drawing.Size(1366, 500);
            this.Load += new System.EventHandler(this.ListDVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDVTF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaSPLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSPLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSPSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDVT1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraGrid.GridControl gcDVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDVT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenDVTF;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMaSPLe;
        private DevExpress.XtraEditors.TextEdit txtSoLuongDoi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTenSPLe;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTenSPSi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenDVT;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMaDVT1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
    }
}
