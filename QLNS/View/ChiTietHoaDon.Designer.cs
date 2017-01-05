namespace QLNS
{
    partial class ChiTietHoaDon
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
            this.gcChiTietHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gcChiTietHoaDon
            // 
            this.gcChiTietHoaDon.Location = new System.Drawing.Point(12, 84);
            this.gcChiTietHoaDon.MainView = this.gvChiTietHoaDon;
            this.gcChiTietHoaDon.Name = "gcChiTietHoaDon";
            this.gcChiTietHoaDon.Size = new System.Drawing.Size(645, 392);
            this.gcChiTietHoaDon.TabIndex = 0;
            this.gcChiTietHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietHoaDon});
            // 
            // gvChiTietHoaDon
            // 
            this.gvChiTietHoaDon.GridControl = this.gcChiTietHoaDon;
            this.gvChiTietHoaDon.Name = "gvChiTietHoaDon";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(201, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(265, 42);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chi Tiết Hóa Đơn";
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 507);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcChiTietHoaDon);
            this.Name = "ChiTietHoaDon";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcChiTietHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}