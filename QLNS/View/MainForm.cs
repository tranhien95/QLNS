using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using QLNS.Model;
using QLNS.DAO;

namespace QLNS.View
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TaiKhoanInfo taikhoan = new TaiKhoanInfo();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDSDVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListDVT listDvt = new ListDVT();
            AddTabControl(listDvt, "Danh Sách ĐVT");
        }

        public void AddTabControl(UserControl userControl, string itemTabName)
        {
            bool isExists = false;
            foreach (XtraTabPage tabItem in xtcHDBH.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExists = true;
                    xtcHDBH.SelectedTabPage = tabItem;
                }
            }
            if (!isExists)
            {
                AddTab addtab = new AddTab();
                addtab.AddTabControl(xtcHDBH, itemTabName, userControl);
            }
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            xtcHDBH.TabPages.RemoveAt(xtcHDBH.SelectedTabPageIndex);
            xtcHDBH.SelectedTabPageIndex = xtcHDBH.TabPages.Count - 1;
        }

        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            xtcHDBH.SelectedTabPageIndex = xtcHDBH.TabPages.Count - 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeTypeMenu(0);
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DangNhap dangnhap = new DangNhap();
            //AddTabControl(dangnhap, "Đăng Nhập");
            DangNhapFrm frm = new DangNhapFrm();
            frm.ShowDialog();
            if(frm.DialogResult== DialogResult.Cancel)
            {
                ChangeTypeMenu(frm.LoaiTK);
                if(frm.LoaiTK>0)
                {
                    taikhoan = frm.taikhoan;
                    ribTaiKhoan.Text = taikhoan.ID;
                }
            }
        }

        public void ChangeTypeMenu(int key)
        {
            switch(key)
            {
                case 0:
                    ribTaiKhoan.Text = "User";
                    ribHoaDon.Visible = false;
                    ribSanPham.Visible = false;
                    ribNCC.Visible = false;
                    ribDVT.Visible = false;
                    ribChiPhi.Visible = false;
                    ribPhieuNhap.Visible = false;
                    ribLoaiSach.Visible = false;
                    ribBaoCao.Visible = false;
                    btnDangXuat.Enabled = false;
                    btnDoiMK.Enabled = false;
                    btnDSTK.Enabled = false;
                    btnThemTK.Enabled = false;
                    btnDangNhap.Enabled = true;
                    break;
                case 1:
                    ribHoaDon.Visible = true;
                    ribSanPham.Visible = true;
                    ribNCC.Visible = true;
                    ribDVT.Visible = true;
                    ribChiPhi.Visible = true;
                    ribPhieuNhap.Visible = true;
                    ribLoaiSach.Visible = true;
                    ribBaoCao.Visible = true;
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnDSTK.Enabled = true;
                    btnThemTK.Enabled = true;
                    btnDangNhap.Enabled = false;
                    break;
                case 2:
                    ribHoaDon.Visible = true;
                    ribSanPham.Visible = true;
                    ribNCC.Visible = false;
                    ribDVT.Visible = false;
                    ribChiPhi.Visible = true;
                    ribPhieuNhap.Visible = false;
                    ribLoaiSach.Visible = false;
                    ribBaoCao.Visible = false;
                    btnDangXuat.Enabled = true;
                    btnDangNhap.Enabled = false;
                    btnDoiMK.Enabled = true;
                    btnDSTK.Enabled = false;
                    btnThemTK.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtcHDBH.TabPages.Clear();
            ChangeTypeMenu(0);
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoiMK doiMK = new DoiMK(taikhoan);
            AddTabControl(doiMK, "Đổi MK");
        }

        private void btnThemTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTK themTK = new ThemTK();
            AddTabControl(themTK, "Thêm TK");
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            HoaDonDAO hoadonDao = new HoaDonDAO();
            HoaDonInfo hoadon = new HoaDonInfo();
            HoaDonInfo[] hoadonArr;
            hoadonArr = hoadonDao.SelectAll();
            int a = hoadonDao.SelectMaxHD();
        }
    }
}