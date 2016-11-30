using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.DAO;
using QLNS.Model;

namespace QLNS.View
{
    public partial class DVTList : Form
    {
        private DVTDAO dvtDAO = new DVTDAO();
        private DVTInfo dvtInfo = new DVTInfo();
        private DVTInfo[] dvtArr;

        public DVTList()
        {
            InitializeComponent();
        }

        private void DVTList_Load(object sender, EventArgs e)
        {
            dvtArr = dvtDAO.SelectAll();
            gcDVT.DataSource = CreateTable(dvtArr.Length);
            for(int i=0; i<dvtArr.Length; i++)
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
    }
}
