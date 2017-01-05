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
using DevExpress.XtraGrid.Columns;
using QLNS.DAO;

namespace QLNS.View
{
    public partial class ThemMoiPhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        private PhieuNhapDAO phieunhap;
        private NCCDAO nhacungcap;
        private SachDAO sach;
        private VPPDAO vpp;
        private DataTable source;
        private DataTable dsdachon;

        public ThemMoiPhieuNhap()
        {
            InitializeComponent();
            phieunhap = new PhieuNhapDAO();
            nhacungcap = new NCCDAO();
            sach = new SachDAO();
            vpp = new VPPDAO();
            source = new DataTable();
            dsdachon = new DataTable();

            source.Columns.Add("Mã sách/vvp", typeof(string));
            source.Columns.Add("Tên sách/vpp", typeof(string));
            source.Columns.Add("Tác giả", typeof(string));
            source.Columns.Add("Đơn giá", typeof(double));
            source.Columns.Add("Số lượng tồn", typeof(int));
            for (int i = 0; i < source.Columns.Count; i++)
            {
                source.Columns[i].ReadOnly = true;
            }

            dsdachon.Columns.Add("Mã sách/vvp", typeof(string));
            dsdachon.Columns.Add("Tên sách/vpp", typeof(string));
            dsdachon.Columns.Add("Tác giả", typeof(string));
            dsdachon.Columns.Add("Đơn giá", typeof(double));
            dsdachon.Columns.Add("Số lượng tồn", typeof(int));
            dsdachon.Columns.Add("Số lượng đặt", typeof(int));
            for(int i = 0; i<dsdachon.Columns.Count - 1; i++)
            {
                dsdachon.Columns[i].ReadOnly = true;
            }

            //gdcDsMatHang.
            //gdcDsMatHangDaChon.Forma
        }

        private void ThemMoiPhieuNhap_Load(object sender, EventArgs e)
        {
            lblNgayLap.Text = DateTime.Today.ToShortDateString();
            lblChiPhiUocTinh.Text = "0";
            int maxpn = phieunhap.SelectMaxPN();
            if(maxpn >= 0)
            {
                lblMaPhieuNhap.Text = (maxpn + 1).ToString();
            }
            else
            {
                lblMaPhieuNhap.Text = "Đã xảy ra lỗi";
                return;
            }

            if(nhacungcap.SelectAll() != null)
            {
                cbbNCC.DataSource = nhacungcap.SelectAll();
                cbbNCC.DisplayMember = "TenNCC";
                cbbNCC.ValueMember = "MaNCC";
            }
            else
            {
                MessageBox.Show("Lỗi select!");
                return;
            }

            gdcDsMatHangDaChon.DataSource = dsdachon;
            gdcDsMatHang.DataSource = source;
            ReLoadData();
            
        }

        private void cbbNCC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ReLoadData();
        }

        private void ReLoadData()
        {
            source.Rows.Clear();
            dsdachon.Clear();
            DataTable dt = sach.TimSachTheoNCC((int)cbbNCC.SelectedValue);
            if(dt != null)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    source.Rows.Add(dt.Rows[i]["MaSach"], dt.Rows[i]["TenSach"], dt.Rows[i]["TacGia"], dt.Rows[i]["Gia"], dt.Rows[i]["SoLuong"]);
                }
            }

            dt = vpp.TimVPPTheoNCC((int)cbbNCC.SelectedValue);

            if(dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    source.Rows.Add(dt.Rows[i]["MaVPP"], dt.Rows[i]["TenVPP"], "", dt.Rows[i]["Gia"], dt.Rows[i]["SoLuong"]);
                }
            }
            //gdcDsMatHang.DataSource = sach.TimSachTheoNCC((int)cbbNCC.SelectedValue);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(source.Rows.Count <= 0)
            {
                return;
            }
            int rowselected = gvDsMatHang.GetSelectedRows()[0];
            if(rowselected >= 0)
            {
                dsdachon.Rows.Add(source.Rows[rowselected][0], source.Rows[rowselected][1], source.Rows[rowselected][2], source.Rows[rowselected][3], source.Rows[rowselected][4], 0);
                source.Rows.RemoveAt(rowselected);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dsdachon.Rows.Count <= 0)
            {
                return;
            }

            int rowselected = gvDsMatHangDaChon.GetSelectedRows()[0];
            if (rowselected >= 0)
            {
                source.Rows.Add(dsdachon.Rows[rowselected][0], dsdachon.Rows[rowselected][1], dsdachon.Rows[rowselected][2], dsdachon.Rows[rowselected][3], dsdachon.Rows[rowselected][4]);
                dsdachon.Rows.RemoveAt(rowselected);
            }
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            bool check = true;
            for(int i = 0; i < dsdachon.Rows.Count; i++)
            {
                if(dsdachon.Rows[i][5].ToString() == "")
                {
                    check = false;
                    break;
                }

                if((int)dsdachon.Rows[i][5] <= 0)
                {
                    check = false;
                    break;
                }
            }

            if(!check)
            {
                MessageBox.Show("Hãy nhập số lượng đặt mua cho các loại mặt hàng!");
                return;
            }
        }

        private void gvDsMatHangDaChon_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

    }
}
