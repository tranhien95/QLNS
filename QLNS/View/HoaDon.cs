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




            String masp = lookUpEdit1.EditValue.ToString();
            String tensp = "";
            String giaSP = "";
            String slCon = "";
            //bool isExist = false;



            if (masp.Contains("VP"))
            {
                QLNS.Model.VanPhongPhamInfo info = new QLNS.DAO.VPPDAO().GetOne(masp);
                if (info == null 
                    || info.DaXoa != 0)
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
                if (info == null || info.DaXoa != 0)
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
            _MaSp.Text = masp;
            _TenSP.Text = tensp;
            _SoLuongCon.Text = slCon;
            _GiaSP.Text = giaSP;

            
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = null;
            List<object> items = new List<object>();
            if (comboBoxEdit1.SelectedItem.ToString() == "Sách")
            {

                QLNS.Model.SachInfo[] sachInfo = new QLNS.DAO.SachDAO().SelectAll();
                //int item = 0;
                foreach (QLNS.Model.SachInfo info in sachInfo)
                {
                    if (info != null && info.DaXoa == 0)
                        items.Add(new { Tên = info.TenSach, Mã = info.MaSach });
                }
            }
            else
            {
                QLNS.Model.VanPhongPhamInfo[] Info = new QLNS.DAO.VPPDAO().SelectAll();

                //int item = 0;
                foreach (QLNS.Model.VanPhongPhamInfo info in Info)
                {
                    if (info != null && info.DaXoa == 0)
                        items.Add(new { Tên = info.TenVPP, Mã = info.MaVPP });
                }
            }
              

            lookUpEdit1.Properties.DataSource = items;
            lookUpEdit1.Properties.DisplayMember = "Tên";
            lookUpEdit1.Properties.ValueMember = "Mã";


            if (items.Count() > 0)
            {
                lookUpEdit1.EditValue = lookUpEdit1.Properties.GetDataSourceValue("Mã", 0);
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            _SoLuongMua.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            lookUpEdit1.Properties.DataSource = null;
            List<object> items = new List<object>();
            if (comboBoxEdit1.SelectedItem.ToString() == "Sách")
            {
                QLNS.Model.SachInfo[] sachInfo = new QLNS.DAO.SachDAO().SelectAll();
                foreach (QLNS.Model.SachInfo info in sachInfo)
                {
                    if (info != null && info.DaXoa == 0)
                        items.Add(new { Tên = info.TenSach, Mã = info.MaSach });
                }


            }
            else
            {
                QLNS.Model.VanPhongPhamInfo[] Info = new QLNS.DAO.VPPDAO().SelectAll();
                foreach (QLNS.Model.VanPhongPhamInfo info in Info)
                {
                    if (info != null && info.DaXoa == 0)
                        items.Add(new { Tên = info.TenVPP, Mã = info.MaVPP });
                }
            }


            lookUpEdit1.Properties.DataSource = items;
            lookUpEdit1.Properties.DisplayMember = "Tên";
            lookUpEdit1.Properties.ValueMember = "Mã";

            if (items.Count() > 0)
            {
                lookUpEdit1.EditValue = lookUpEdit1.Properties.GetDataSourceValue("Mã", 0);
            }





            QLNS.Model.HoaDonInfo[] hoaDonInfo = new QLNS.DAO.HoaDonDAO().SelectAll();
            int maDon = 1;
            for (int i = 0; i < hoaDonInfo.Count(); i++)
            {
                if (hoaDonInfo[i] != null && maDon == hoaDonInfo[i].MaDon)
                {
                    maDon++;
                }
            }

            _MaDon.Text = maDon.ToString();



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_SoLuongMua.Text == "" || int.Parse(_SoLuongMua.Text) == 0)
                {
                    MessageBox.Show("Số lượng mua không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (int.Parse(_SoLuongCon.Text) < int.Parse(_SoLuongMua.Text))
                {
                    MessageBox.Show("Không còn đủ số lượng để bán!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int thanhTien = int.Parse(_GiaSP.Text) * int.Parse(_SoLuongMua.Text);
                    this.chiTietHoaDon.Rows.Add(_MaSp.Text, _TenSP.Text, _SoLuongMua.Text, thanhTien.ToString());
                    TinhTien();
                    
                }

            }
            catch(Exception exc)
            {

            }
            
        }


        private void TinhTien()
        {
            try
            {
                int tongtien = 0;
               // foreach (DataGridViewRow row in chiTietHoaDon.Rows)
                for (int i = 0; i < chiTietHoaDon.Rows.Count; i++)
			    {
                    DataGridViewRow row = chiTietHoaDon.Rows[i];
                    if (row.Cells[3].Value != null)
                        tongtien += int.Parse(row.Cells[3].Value.ToString());
			    }
                //{
                //    if (row. != null)
                //        tongtien += int.Parse(row.Cells[3].Value.ToString());
                //}
                _TongTien.Text = tongtien.ToString();
                //.tongtien.MessageBox.Show("" + tongtien, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exc)
            {

            }
        }

        public int generateMaCTHD()
        {
            try
            {
                int maHD = 1;;
                QLNS.Model.CTHDInfo[] CTHDInfo = new QLNS.DAO.CTHDDAO().SelectAll();
                for (int i = 0; i < CTHDInfo.Count(); i++)
                {
                    if (CTHDInfo[i] != null && maHD == CTHDInfo[i].MaCTHD)
                    {
                        maHD++;
                    }
                }
                return maHD;

            }
            catch (Exception)
            {
                
                return -1;
            } 
            
        }





        
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {

                if (chiTietHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Vui lòng nhập vào sản phẩm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                QLNS.Model.HoaDonInfo hoadon = new Model.HoaDonInfo();
                hoadon.MaDon = int.Parse(_MaDon.Text);
                hoadon.NgayLap = dateTimePicker1.Value;
                hoadon.TongTien = int.Parse(_TongTien.Text);
                if (new QLNS.DAO.HoaDonDAO().Insert(hoadon) == false)
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                    



                QLNS.Model.CTHDInfo CTHoaDon = new Model.CTHDInfo();


                QLNS.DAO.CTHDDAO CTHDDao = new QLNS.DAO.CTHDDAO();
                foreach (DataGridViewRow row in chiTietHoaDon.Rows)
                {
                    if (row != null &&(row.Cells[0].Value != null)
                                    && (row.Cells[1].Value != null)
                                    && (row.Cells[2].Value != null)
                                    && (row.Cells[3].Value != null))
                    {

                        CTHoaDon.MaCTHD = generateMaCTHD();
                        CTHoaDon.MaHD = hoadon.MaDon;
                        CTHoaDon.MaSP = (row.Cells[0].Value.ToString());
                        CTHoaDon.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                        CTHoaDon.TongTien = int.Parse(row.Cells[3].Value.ToString());
                        if (CTHDDao.Insert(CTHoaDon) == false)
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if(CTHoaDon.MaSP.Contains("VP"))
                        {
                            QLNS.DAO.VPPDAO VPDAO = new QLNS.DAO.VPPDAO();
                            QLNS.Model.VanPhongPhamInfo vppInfo = VPDAO.GetOne(CTHoaDon.MaSP);
                            vppInfo.SoLuong -= CTHoaDon.SoLuong;
                            if (VPDAO.Update(vppInfo) == false)
                            {
                                MessageBox.Show("Có lỗi xảy ra khi cập nhật VPP!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            QLNS.DAO.SachDAO sachDAO = new QLNS.DAO.SachDAO();
                            QLNS.Model.SachInfo SachInfo = sachDAO.GetOne(CTHoaDon.MaSP);
                            SachInfo.SoLuong -= CTHoaDon.SoLuong;
                            if (sachDAO.Update(SachInfo) == false)
                            {
                                MessageBox.Show("Có lỗi xảy ra khi cập nhật sach!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    

                }

                MessageBox.Show("Thành Công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.chiTietHoaDon.SelectedRows.Count > 0)
                {
                    chiTietHoaDon.Rows.RemoveAt(this.chiTietHoaDon.SelectedRows[0].Index);
                }
            }
            catch (Exception)
            {
                
                
            }
            
        }
    }


}