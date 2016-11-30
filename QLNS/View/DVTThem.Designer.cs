namespace QLNS.View
{
    partial class DVTThem
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
            this.txtTenDVT = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuongDoi = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbbMaSPLe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaSPLe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDVT
            // 
            this.txtTenDVT.Location = new System.Drawing.Point(118, 51);
            this.txtTenDVT.Name = "txtTenDVT";
            this.txtTenDVT.Properties.MaxLength = 50;
            this.txtTenDVT.Size = new System.Drawing.Size(144, 20);
            this.txtTenDVT.TabIndex = 0;
            // 
            // txtSoLuongDoi
            // 
            this.txtSoLuongDoi.Location = new System.Drawing.Point(118, 151);
            this.txtSoLuongDoi.Name = "txtSoLuongDoi";
            this.txtSoLuongDoi.Properties.MaxLength = 3;
            this.txtSoLuongDoi.Size = new System.Drawing.Size(56, 20);
            this.txtSoLuongDoi.TabIndex = 1;
            this.txtSoLuongDoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(53, 213);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên DVT:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã SP Lẻ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Số Lượng Đổi:";
            // 
            // cbbMaSPLe
            // 
            this.cbbMaSPLe.Location = new System.Drawing.Point(118, 103);
            this.cbbMaSPLe.Name = "cbbMaSPLe";
            this.cbbMaSPLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaSPLe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbMaSPLe.Size = new System.Drawing.Size(126, 20);
            this.cbbMaSPLe.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(157, 213);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // DVTThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 261);
            this.Controls.Add(this.cbbMaSPLe);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuongDoi);
            this.Controls.Add(this.txtTenDVT);
            this.Name = "DVTThem";
            this.Text = "DVTThem";
            this.Load += new System.EventHandler(this.DVTThem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaSPLe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTenDVT;
        private DevExpress.XtraEditors.TextEdit txtSoLuongDoi;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMaSPLe;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}