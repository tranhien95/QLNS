using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNS.DAO;
using QLNS.Model;
using QLNS.View;
using QLNS.Utilities;

namespace QLNS
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        private TaiKhoanDAO AccDAO = new TaiKhoanDAO();

        const string IDS_SUCCESS_LOGIN = "Đăng nhập thành công!";
        const string IDS_FAIL_LOGIN = "Đăng nhập thất bại!";

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanInfo AccInfo = new TaiKhoanInfo();
            QLNS.Services.LogIn logInSer = new QLNS.Services.LogIn();
            AccInfo.ID = txtTaiKhoan.Text;
            AccInfo.Pass = txtMatKhau.Text;
            if (logInSer.CheckPass(AccInfo))
            {
                MessageBox.Show(IDS_SUCCESS_LOGIN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mp = new MainForm();
                mp.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(IDS_FAIL_LOGIN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
