namespace QLNS
{
    partial class DanhSachHoaDon
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.GridControlDanhSachHoaDon = new DevExpress.XtraGrid.GridControl();
            this.GVDanhSachHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDanhSachHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVDanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControlDanhSachHoaDon
            // 
            gridLevelNode1.RelationName = "Level1";
            this.GridControlDanhSachHoaDon.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.GridControlDanhSachHoaDon.Location = new System.Drawing.Point(12, 56);
            this.GridControlDanhSachHoaDon.MainView = this.GVDanhSachHoaDon;
            this.GridControlDanhSachHoaDon.Name = "GridControlDanhSachHoaDon";
            this.GridControlDanhSachHoaDon.Size = new System.Drawing.Size(956, 432);
            this.GridControlDanhSachHoaDon.TabIndex = 0;
            this.GridControlDanhSachHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVDanhSachHoaDon});
            // 
            // GVDanhSachHoaDon
            // 
            this.GVDanhSachHoaDon.GridControl = this.GridControlDanhSachHoaDon;
            this.GVDanhSachHoaDon.Name = "GVDanhSachHoaDon";
            this.GVDanhSachHoaDon.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GVDanhSachHoaDon.PaintStyleName = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(328, -1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(314, 42);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Danh Sách Hóa Đơn";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(791, 530);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Xem Chi Tiết";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(893, 530);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Thoát";
            // 
            // DanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 589);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GridControlDanhSachHoaDon);
            this.Name = "DanhSachHoaDon";
            this.Text = "DanhSachHoaDon";
            this.Load += new System.EventHandler(this.DanhSachHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDanhSachHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVDanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridControlDanhSachHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView GVDanhSachHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}