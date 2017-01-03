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
    public partial class DangNhapFrm : DevExpress.XtraEditors.XtraForm
    {
        public int LoaiTK = 0;

        public TaiKhoanInfo taikhoan = new TaiKhoanInfo();

        private TaiKhoanDAO AccDAO = new TaiKhoanDAO();

        const string IDS_SUCCESS_LOGIN = "Đăng nhập thành công!";
        const string IDS_FAIL_LOGIN = "Đăng nhập thất bại!";

        public DangNhapFrm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanInfo AccInfo = new TaiKhoanInfo();
            QLNS.Services.LogIn logInSer = new QLNS.Services.LogIn();
            AccInfo.ID = txtTaiKhoan.Text;
            AccInfo.Pass = txtMatKhau.Text;
            LoaiTK = logInSer.CheckPass(AccInfo);
            if (LoaiTK>0)
            {
                MessageBox.Show(IDS_SUCCESS_LOGIN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taikhoan.ID = txtTaiKhoan.Text;
                taikhoan.Pass = txtMatKhau.Text;
                taikhoan.LoaiTK = LoaiTK;
                this.Close();
            }
            else
            {
                MessageBox.Show(IDS_FAIL_LOGIN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
