namespace QLNS.View
{
    partial class DoiMK
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDoiMK = new DevExpress.XtraEditors.SimpleButton();
            this.txtMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtMKCu = new DevExpress.XtraEditors.TextEdit();
            this.txtMKMoi2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Mật Khẩu Mới:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mật Khẩu Cũ:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(91, 214);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMK.TabIndex = 6;
            this.btnDoiMK.Text = "Đổi MK";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(125, 87);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Properties.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(100, 20);
            this.txtMKMoi.TabIndex = 4;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(125, 28);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Properties.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(100, 20);
            this.txtMKCu.TabIndex = 4;
            // 
            // txtMKMoi2
            // 
            this.txtMKMoi2.Location = new System.Drawing.Point(125, 141);
            this.txtMKMoi2.Name = "txtMKMoi2";
            this.txtMKMoi2.Properties.PasswordChar = '*';
            this.txtMKMoi2.Size = new System.Drawing.Size(100, 20);
            this.txtMKMoi2.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Nhập Lại MK:";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtMKMoi);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtMKMoi2);
            this.panelControl1.Controls.Add(this.txtMKCu);
            this.panelControl1.Controls.Add(this.btnDoiMK);
            this.panelControl1.Location = new System.Drawing.Point(517, 80);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(253, 260);
            this.panelControl1.TabIndex = 9;
            // 
            // DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "DoiMK";
            this.Size = new System.Drawing.Size(1300, 475);
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDoiMK;
        private DevExpress.XtraEditors.TextEdit txtMKMoi;
        private DevExpress.XtraEditors.TextEdit txtMKCu;
        private DevExpress.XtraEditors.TextEdit txtMKMoi2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
