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
    class PhieuNhapDAO:BaseDAO
    {
        public PhieuNhapInfo[] SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from PHIEUNHAP";
                dt = GetTable(cmd, "PHIEUNHAP");
                PhieuNhapInfo[] phieunhap = new PhieuNhapInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    phieunhap[i] = new PhieuNhapInfo();
                    phieunhap[i].MaPhieu = int.Parse(row["MaPhieu"].ToString());
                    phieunhap[i].NgayLap = (DateTime)row["NgayLap"];
                    phieunhap[i].TrangThai = int.Parse(row["TrangThai"].ToString());
                    phieunhap[i].ChiPhiUocTinh = double.Parse(row["TongTien"].ToString());
                    phieunhap[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                    i++;
                }
                return phieunhap;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool Insert(PhieuNhapInfo phieunhap)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into PHIEUNHAP values(@MaPhieu, @NgayLap, @TrangThai, @ChiPhiUocTinh, MaNCC)";
                cmd.Parameters.Add("@MaPhieu", SqlDbType.Int);
                cmd.Parameters.Add("@NgayLap", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@TrangThai", SqlDbType.Int);
                cmd.Parameters.Add("@ChiPhiUocTinh", SqlDbType.Money);
                cmd.Parameters.Add("@MaNCC", SqlDbType.Int);

                cmd.Parameters["@MaPhieu"].Value = phieunhap.MaPhieu;
                cmd.Parameters["@NgayLap"].Value = phieunhap.NgayLap;
                cmd.Parameters["@TrangThai"].Value = phieunhap.TrangThai;
                cmd.Parameters["@ChiPhiUocTinh"].Value = phieunhap.ChiPhiUocTinh;
                cmd.Parameters["@MaNCC"].Value = phieunhap.MaNCC;
                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int SelectMaxPN()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from PHIEUNHAP order by MaPhieu desc";
                int max = Int32.Parse(GetMax(cmd, "MaPhieu"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public PhieuNhapInfo[] TimMaPN(string maphieu)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from PHIEUNHAP where MaPhieu = " + maphieu;
                dt = GetTable(cmd, "PHIEUNHAP");
                PhieuNhapInfo[] phieunhap = new PhieuNhapInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    phieunhap[i] = new PhieuNhapInfo();
                    phieunhap[i].MaPhieu = int.Parse(row["MaPhieu"].ToString());
                    phieunhap[i].NgayLap = (DateTime)row["NgayLap"];
                    phieunhap[i].TrangThai = int.Parse(row["TrangThai"].ToString());
                    phieunhap[i].ChiPhiUocTinh = double.Parse(row["TongTien"].ToString());
                    phieunhap[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                    i++;
                }
                return phieunhap;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public PhieuNhapInfo GetOne(int maphieunhap)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from PHIEUNHAP where MaPhieu = " + maphieunhap.ToString();
                dt = GetTable(cmd, "PHIEUNHAP");
                PhieuNhapInfo phieunhap = new PhieuNhapInfo();
                phieunhap.MaPhieu = int.Parse(dt.Rows[0]["MaPhieu"].ToString());
                phieunhap.NgayLap = DateTime.ParseExact(dt.Rows[0]["NgayLap"].ToString(), "dd/MM/yyyy", null);
                phieunhap.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
                phieunhap.ChiPhiUocTinh = double.Parse(dt.Rows[0]["TongTien"].ToString());
                phieunhap.MaNCC = int.Parse(dt.Rows[0]["MaNCC"].ToString());
                return phieunhap;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
    }
}
