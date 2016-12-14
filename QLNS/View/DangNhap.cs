using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNS.DAO;
using QLNS.Model;
using QLNS.View;
using QLNS.Utilities;


namespace QLNS.View
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public int LoaiTK = 0;

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
            LoaiTK = logInSer.CheckPass(AccInfo);
            if (LoaiTK>0)
            {
                MessageBox.Show(IDS_SUCCESS_LOGIN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(IDS_FAIL_LOGIN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
