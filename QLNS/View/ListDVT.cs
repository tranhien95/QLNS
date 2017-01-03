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
    public partial class ListDVT : DevExpress.XtraEditors.XtraUserControl
    {
        private DVTDAO dvtDAO = new DVTDAO();
        private DVTInfo dvtInfo = new DVTInfo();
        private DVTInfo[] dvtArr;

        public ListDVT()
        {
            InitializeComponent();
        }

        private void ListDVT_Load(object sender, EventArgs e)
        {
            dvtArr = dvtDAO.SelectAll();
            gcDVT.DataSource = CreateTable(dvtArr.Length);
            for (int i = 0; i < dvtArr.Length; i++)
            {
                gvDVT.AddNewRow();
                int newRowHandle = gvDVT.FocusedRowHandle;

                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[0], dvtArr[i].MaDVT);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[1], dvtArr[i].TenDVT);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[2], dvtArr[i].MaVPPLe);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[3], dvtArr[i].SoLuongDoi);
                gvDVT.UpdateCurrentRow();
                gvDVT.RefreshData();
            }
        }

        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Mã DVT", typeof(string));
            tbl.Columns.Add("Tên DVT", typeof(string));
            tbl.Columns.Add("Mã SP Lẻ", typeof(string));
            tbl.Columns.Add("Số Lượng Đổi", typeof(int));
            return tbl;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (gvDVT.RowCount>0)
            {
                int madvt = gvDVT.GetSelectedRows()[0];
                dvtInfo = dvtDAO.GetOne(madvt);
                txtMaDVT1.Text = dvtInfo.MaDVT.ToString();
                txtTenDVT.Text = dvtInfo.TenDVT;
                txtSoLuongDoi.Text = dvtInfo.SoLuongDoi.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dvtArr = dvtDAO.TimTenDVT(txtTenDVTF.Text);
            gcDVT.DataSource = CreateTable(dvtArr.Length);
            for (int i = 0; i < dvtArr.Length; i++)
            {
                gvDVT.AddNewRow();
                int newRowHandle = gvDVT.FocusedRowHandle;

                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[0], dvtArr[i].MaDVT);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[1], dvtArr[i].TenDVT);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[2], dvtArr[i].MaVPPLe);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[3], dvtArr[i].SoLuongDoi);
                gvDVT.UpdateCurrentRow();
                gvDVT.RefreshData();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dvtArr = dvtDAO.SelectAll();
            gcDVT.DataSource = CreateTable(dvtArr.Length);
            for (int i = 0; i < dvtArr.Length; i++)
            {
                gvDVT.AddNewRow();
                int newRowHandle = gvDVT.FocusedRowHandle;

                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[0], dvtArr[i].MaDVT);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[1], dvtArr[i].TenDVT);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[2], dvtArr[i].MaVPPLe);
                gvDVT.SetRowCellValue(newRowHandle, gvDVT.Columns[3], dvtArr[i].SoLuongDoi);
                gvDVT.UpdateCurrentRow();
                gvDVT.RefreshData();
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
