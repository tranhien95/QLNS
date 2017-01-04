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
    class CTHDDAO:BaseDAO
    {
        public CTHDInfo[] SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CTHD";
                dt = GetTable(cmd, "CTHD");
                CTHDInfo[] cthd = new CTHDInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    cthd[i] = new CTHDInfo();
                    cthd[i].MaCTHD = int.Parse(row["MaCTHD"].ToString());
                    cthd[i].MaHD = int.Parse(row["MaHD"].ToString());
                    cthd[i].MaSP = row["MaSP"].ToString();
                    cthd[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    cthd[i].TongTien = double.Parse(row["TongTien"].ToString());
                    i++;
                }
                return cthd;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool Insert(CTHDInfo cthd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into CTHD values(@MaCTHD, @MaHD, @MaSP, @SoLuong, @TongTien)";
                cmd.Parameters.Add("@MaCTHD", SqlDbType.Int);
                cmd.Parameters.Add("@MaHD", SqlDbType.Int);
                cmd.Parameters.Add("@MaSP", SqlDbType.Char, 10);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmd.Parameters.Add("@TongTien", SqlDbType.Money);

                cmd.Parameters["@MaCTHD"].Value = cthd.MaCTHD;
                cmd.Parameters["@MaHD"].Value = cthd.MaHD;
                cmd.Parameters["@MaSP"].Value = cthd.MaSP;
                cmd.Parameters["@SoLuong"].Value = cthd.SoLuong;
                cmd.Parameters["@TongTien"].Value = cthd.TongTien;
                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int SelectMaxCTHD()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CTHD order by MaCTHD desc";
                int max = Int32.Parse(GetMax(cmd, "MaCTHD"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public CTHDInfo[] TimMaCTHD(string macthd)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CTHD where MaCTHD = " + macthd;
                dt = GetTable(cmd, "CTHD");
                CTHDInfo[] cthd = new CTHDInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    cthd[i] = new CTHDInfo();
                    cthd[i].MaCTHD = int.Parse(row["MaCTHD"].ToString());
                    cthd[i].MaHD = int.Parse(row["MaHD"].ToString());
                    cthd[i].MaSP = row["MaSP"].ToString();
                    cthd[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    cthd[i].TongTien = double.Parse(row["TongTien"].ToString());
                    i++;
                }
                return cthd;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public CTHDInfo GetOne(int macthd)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CTHD where MaCTHD = " + macthd.ToString();
                dt = GetTable(cmd, "CTHD");
                CTHDInfo cthd = new CTHDInfo();
                cthd.MaCTHD = int.Parse(dt.Rows[0]["MaCTHD"].ToString());
                cthd.MaHD = int.Parse(dt.Rows[0]["MaHD"].ToString());
                cthd.MaSP = dt.Rows[0]["MaSP"].ToString();
                cthd.SoLuong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
                cthd.TongTien = double.Parse(dt.Rows[0]["TongTien"].ToString());
                return cthd;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
    }
}
