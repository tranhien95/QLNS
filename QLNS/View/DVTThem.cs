using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.Model;
using QLNS.DAO;

namespace QLNS.View
{
    public partial class DVTThem : Form
    {
        private VanPhongPhamInfo[] VppArr;
        private VPPDAO VppDAO = new VPPDAO();
        private DVTDAO DvtDAO = new DVTDAO();
        private DVTInfo DvtInfo = new DVTInfo();

        public DVTThem()
        {
            InitializeComponent();
        }

        private void DVTThem_Load(object sender, EventArgs e)
        {
            VppArr = VppDAO.SelectAll();
            int i = 0;
            while (VppArr[i] != null)
            {
                cbbMaSPLe.Properties.Items.Add(VppArr[i].TenVPP.ToString());
                i++;
            }
        }

        private void CheckNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckCT())
            {
                MessageBox.Show("Không được để trống các trường", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    DvtInfo.MaDVT = DvtDAO.SelectMaxDVT() + 1;
                    DvtInfo.TenDVT = txtTenDVT.Text;
                    DvtInfo.SoLuongDoi = int.Parse(txtSoLuongDoi.Text);
                    DvtInfo.MaVPPChan = VppArr[cbbMaSPLe.SelectedIndex].MaVPP;
                    DvtDAO.Insert(DvtInfo);
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuongDoi.Text = "";
                    txtTenDVT.Text = "";
                    cbbMaSPLe.SelectedIndex = 0;

                }
                catch(Exception)
                {
                    MessageBox.Show("Không thêm được.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private bool CheckCT()
        {
            if (this.cbbMaSPLe.SelectedItem == null ||
                this.txtSoLuongDoi.Text == "" ||
                this.txtTenDVT.Text == "")
                return false;
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
