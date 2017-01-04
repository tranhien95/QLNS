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
    class HoaDonDAO:BaseDAO
    {
        public HoaDonInfo[] SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from HOADON";
                dt = GetTable(cmd, "HOADON");
                HoaDonInfo[] hoadon = new HoaDonInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    hoadon[i] = new HoaDonInfo();
                    hoadon[i].MaDon = int.Parse(row["MaDon"].ToString());
                    hoadon[i].NgayLap = (DateTime)row["NgayLap"];
                    hoadon[i].TongTien = double.Parse(row["TongTien"].ToString());
                    i++;
                }
                return hoadon;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool Insert(HoaDonInfo hoadon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into HOADON values(@MaDon, @NgayLap, @TongTien)";
                cmd.Parameters.Add("@MaDon", SqlDbType.Int);
                cmd.Parameters.Add("@NgayLap", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@TongTien", SqlDbType.Money);

                cmd.Parameters["@MaDon"].Value = hoadon.MaDon;
                cmd.Parameters["@NgayLap"].Value = hoadon.NgayLap;
                cmd.Parameters["@TongTien"].Value = hoadon.TongTien;
                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int SelectMaxHD()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from HOADON order by MaDon desc";
                int max = Int32.Parse(GetMax(cmd, "MaDon"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public HoaDonInfo[] TimMaHD(string madon)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from HOADON where MaDon = " + madon;
                dt = GetTable(cmd, "HOADON");
                HoaDonInfo[] hoadon = new HoaDonInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    hoadon[i] = new HoaDonInfo();
                    hoadon[i].MaDon = int.Parse(row["MaDon"].ToString());
                    hoadon[i].NgayLap = (DateTime)row["NgayLap"];
                    hoadon[i].TongTien = double.Parse(row["TongTien"].ToString());
                    i++;
                }
                return hoadon;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public HoaDonInfo GetOne(int mahoadon)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from HOADON where MaDon = " + mahoadon.ToString();
                dt = GetTable(cmd, "HOADON");
                HoaDonInfo hoadon = new HoaDonInfo();
                hoadon.MaDon = int.Parse(dt.Rows[0]["MaDon"].ToString());
                hoadon.NgayLap = (DateTime)dt.Rows[0]["NgayLap"];
                hoadon.TongTien = double.Parse(dt.Rows[0]["TongTien"].ToString());
                return hoadon;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
    }
}
