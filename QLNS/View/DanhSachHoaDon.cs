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
    public partial class DanhSachHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {

            QLNS.Model.HoaDonInfo[] hoaDonInfo = new QLNS.DAO.HoaDonDAO().SelectAll();


            GridControlDanhSachHoaDon.DataSource = CreateTable(hoaDonInfo.Length);
            for (int i = 0; i < hoaDonInfo.Length; i++)
            {
                GVDanhSachHoaDon.AddNewRow();
                int newRowHandle = GVDanhSachHoaDon.FocusedRowHandle;

                GVDanhSachHoaDon.SetRowCellValue(newRowHandle, GVDanhSachHoaDon.Columns[0], hoaDonInfo[i].MaDon);
                GVDanhSachHoaDon.SetRowCellValue(newRowHandle, GVDanhSachHoaDon.Columns[1], hoaDonInfo[i].NgayLap);
                GVDanhSachHoaDon.SetRowCellValue(newRowHandle, GVDanhSachHoaDon.Columns[2], hoaDonInfo[i].TongTien);
                GVDanhSachHoaDon.UpdateCurrentRow();
                GVDanhSachHoaDon.RefreshData();
            }
        }



        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Mã Hóa Đơn", typeof(string));
            tbl.Columns.Add("Ngày Lập", typeof(string));
            tbl.Columns.Add("Tổng Tiền", typeof(string));
            return tbl;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try 
	        {
                int row = GVDanhSachHoaDon.FocusedRowHandle;
                

	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
            
        }
    }
}