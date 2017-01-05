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

namespace QLNS
{
    public partial class ChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public ChiTietHoaDon( int maHD )
        {
            InitializeComponent();
        }


        //QLNS.Model.CTHDInfo[] hoaDonInfo = new QLNS.DAO.CTHDDAO().GetOne()


        //    GridControlDanhSachHoaDon.DataSource = CreateTable(hoaDonInfo.Length);
        //    for (int i = 0; i < hoaDonInfo.Length; i++)
        //    {
        //        GVDanhSachHoaDon.AddNewRow();
        //        int newRowHandle = GVDanhSachHoaDon.FocusedRowHandle;

        //        GVDanhSachHoaDon.SetRowCellValue(newRowHandle, GVDanhSachHoaDon.Columns[0], hoaDonInfo[i].MaDon);
        //        GVDanhSachHoaDon.SetRowCellValue(newRowHandle, GVDanhSachHoaDon.Columns[1], hoaDonInfo[i].NgayLap);
        //        GVDanhSachHoaDon.SetRowCellValue(newRowHandle, GVDanhSachHoaDon.Columns[2], hoaDonInfo[i].TongTien);
        //        GVDanhSachHoaDon.UpdateCurrentRow();
        //        GVDanhSachHoaDon.RefreshData();
        //    }





    }









    //private System.Data.DataTable CreateTable(int RowCount)
    //{
    //    DataTable tbl = new DataTable();
    //    tbl.Columns.Add("Mã Hóa Đơn", typeof(string));
    //    tbl.Columns.Add("Ngày Lập", typeof(string));
    //    tbl.Columns.Add("Tổng Tiền", typeof(string));
    //    return tbl;
    //}
}