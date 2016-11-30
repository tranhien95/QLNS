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
            ((System.ComponentModel.ISupportInitialize)(this.gcDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDVT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTim.Location = new System.Drawing.Point(542, 13);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(70, 60);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnChiTiet.Location = new System.Drawing.Point(634, 13);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(70, 60);
            this.btnChiTiet.TabIndex = 0;
            this.btnChiTiet.Text = "Chi tiết";
            // 
            // gcDVT
            // 
            this.gcDVT.Location = new System.Drawing.Point(135, 97);
            this.gcDVT.MainView = this.gvDVT;
            this.gcDVT.Name = "gcDVT";
            this.gcDVT.Size = new System.Drawing.Size(613, 177);
            this.gcDVT.TabIndex = 1;
            this.gcDVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDVT});
            // 
            // gvDVT
            // 
            this.gvDVT.GridControl = this.gcDVT;
            this.gvDVT.Name = "gvDVT";
            // 
            // ListDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDVT);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnTim);
            this.Name = "ListDVT";
            this.Size = new System.Drawing.Size(921, 335);
            this.Load += new System.EventHandler(this.ListDVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDVT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraGrid.GridControl gcDVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDVT;
    }
}
