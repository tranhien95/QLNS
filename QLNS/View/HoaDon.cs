using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLNS.View
{
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
        public HoaDon()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (textEdit2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            String masp = textEdit2.Text;
            String tensp = "";
            String giaSP = "";
            String slCon = "";
            //bool isExist = false;
            if (masp.Contains("VP"))
            {
                QLNS.Model.VanPhongPhamInfo info = new QLNS.DAO.VPPDAO().GetOne(masp);
                if (info == null)
                {
                    MessageBox.Show("Không tồn tại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    tensp = info.TenVPP;
                    giaSP = info.Gia.ToString();
                    slCon = info.SoLuong.ToString();
                    
                }
               // QLNS.DAO.VPPDAO vpInfo = new Model.VanPhongPhamInfo();
    
            }
            else if (masp.Contains("SA"))
            {
                QLNS.Model.SachInfo info = new QLNS.DAO.SachDAO().GetOne(masp);
                if (info == null)
                {
                    MessageBox.Show("Không tồn tại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    tensp = info.TenSach;
                    giaSP = info.Gia.ToString();
                    slCon = info.SoLuong.ToString();
                }

            }
            else
            {

                    MessageBox.Show("Không tồn tại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            _TenSP.Text = tensp;
            _SoLuongCon.Text = slCon;
            _GiaSP.Text = giaSP;

            
        }
    }


}