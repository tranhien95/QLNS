using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLNS.DAO
{
    class HoaDonNhapNhapDAO:BaseDAO
    {
        public HoaDonNhapInfo[] SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from HOADONNHAP";
                dt = GetTable(cmd, "HOADONNHAP");
                HoaDonNhapInfo[] hoadon = new HoaDonNhapInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    hoadon[i] = new HoaDonNhapInfo();
                    hoadon[i].MaHDN = int.Parse(row["MaHDN"].ToString());
                    hoadon[i].MaPN = int.Parse(row["MaPN"].ToString());
                    hoadon[i].NgayLap = (DateTime)row["NgayLap"];
                    hoadon[i].ThanhTien = double.Parse(row["ThanhTien"].ToString());
                    i++;
                }
                return hoadon;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool Insert(HoaDonNhapInfo hoadon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into HOADONNHAP values(@MaHDN, @NgayLap, @ThanhTien, @MaPN)";
                cmd.Parameters.Add("@MaHDN", SqlDbType.Int);
                cmd.Parameters.Add("@NgayLap", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Money);
                cmd.Parameters.Add("@MaPN", SqlDbType.Int);

                cmd.Parameters["@MaHDN"].Value = hoadon.MaHDN;
                cmd.Parameters["@NgayLap"].Value = hoadon.NgayLap;
                cmd.Parameters["@ThanhTien"].Value = hoadon.ThanhTien;
                cmd.Parameters["@MaPN"].Value = hoadon.MaPN;
                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int SelectMaxHDN()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from HOADONNHAP order by MaHDN desc";
                int max = Int32.Parse(GetMax(cmd, "MaHDN"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public HoaDonNhapInfo[] TimMaHDN(string madon)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from HOADONNHAP where MaHDN = " + madon;
                dt = GetTable(cmd, "HOADONNHAP");
                HoaDonNhapInfo[] hoadon = new HoaDonNhapInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    hoadon[i] = new HoaDonNhapInfo();
                    hoadon[i].MaHDN = int.Parse(row["MaHDN"].ToString());
                    hoadon[i].MaPN = int.Parse(row["MaPN"].ToString());
                    hoadon[i].NgayLap = (DateTime)row["NgayLap"];
                    hoadon[i].ThanhTien = double.Parse(row["ThanhTien"].ToString());
                    i++;
                }
                return hoadon;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public HoaDonNhapInfo GetOne(int mahoadon)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from HOADONNHAP where MaHDN = " + mahoadon.ToString();
                dt = GetTable(cmd, "HOADONNHAP");
                HoaDonNhapInfo hoadon = new HoaDonNhapInfo();
                hoadon.MaHDN = int.Parse(dt.Rows[0]["MaHDN"].ToString());
                hoadon.NgayLap = (DateTime)dt.Rows[0]["NgayLap"];
                hoadon.ThanhTien = double.Parse(dt.Rows[0]["MaVPPLe"].ToString());
                return hoadon;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
    }
}
