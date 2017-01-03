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

namespace QLNS.View
{
    public partial class DoiMK : DevExpress.XtraEditors.XtraUserControl
    {
        private TaiKhoanInfo taikhoan = new TaiKhoanInfo();

        public DoiMK(TaiKhoanInfo tk)
        {
            InitializeComponent();
            taikhoan = tk;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {  
            if(txtMKCu.Text.Equals("")||txtMKMoi.Text.Equals("")||txtMKMoi2.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!txtMKMoi.Text.Equals(txtMKMoi2.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiKhoanInfo tk = new TaiKhoanInfo();
            tk.Pass = txtMKCu.Text;

            if(!tk.Pass.Equals(taikhoan.Pass))
            {
                MessageBox.Show("Sai mật khẩu hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            taikhoan.Pass = txtMKMoi.Text;

            TaiKhoanDAO taikhoanDao = new TaiKhoanDAO();

            taikhoanDao.UpdatePassWord(taikhoan.ID, taikhoan.Pass);

            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
