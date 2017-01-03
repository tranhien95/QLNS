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
using QLNS.Model;
using QLNS.DAO;

namespace QLNS.View
{
    public partial class ThemTK : DevExpress.XtraEditors.XtraUserControl
    {
        public ThemTK()
        {
            InitializeComponent();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if(txtTenTK.Text.Equals("")||txtMKMoi.Text.Equals("")||txtMKMoi2.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             QLNS.Services.LogIn logInSer = new QLNS.Services.LogIn();

            TaiKhoanInfo taikhoan = new TaiKhoanInfo();
            taikhoan.ID = txtTenTK.Text;

            if(logInSer.CheckAcc(taikhoan))
            {
                MessageBox.Show("Trùng tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!txtMKMoi.Text.Equals(txtMKMoi2.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            taikhoan.LoaiTK = 2;
            taikhoan.Pass = txtMKMoi.Text;

            TaiKhoanDAO taikhoanDao = new TaiKhoanDAO();

            taikhoanDao.InsertAccount(taikhoan);

        }
    }
}
