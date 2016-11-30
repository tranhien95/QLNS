namespace QLNS.View
{
    partial class DVTList
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
            this.gcDVT = new DevExpress.XtraGrid.GridControl();
            this.gvDVT = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDVT)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDVT
            // 
            this.gcDVT.Location = new System.Drawing.Point(104, 83);
            this.gcDVT.MainView = this.gvDVT;
            this.gcDVT.Name = "gcDVT";
            this.gcDVT.Size = new System.Drawing.Size(400, 303);
            this.gcDVT.TabIndex = 0;
            this.gcDVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDVT});
            // 
            // gvDVT
            // 
            this.gvDVT.GridControl = this.gcDVT;
            this.gvDVT.Name = "gvDVT";
            // 
            // DVTList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 485);
            this.Controls.Add(this.gcDVT);
            this.Name = "DVTList";
            this.Text = "List DVT";
            this.Load += new System.EventHandler(this.DVTList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDVT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDVT;
    }
}