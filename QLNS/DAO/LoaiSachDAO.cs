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
    class LoaiSachDAO:BaseDAO
    {
        public LoaiSachInfo[] SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from LOAISACH";
                dt = GetTable(cmd, "LOAISACH");
                LoaiSachInfo[] loaisach = new LoaiSachInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    loaisach[i] = new LoaiSachInfo();
                    loaisach[i].MaLoai = int.Parse(row["MaLoai"].ToString());
                    loaisach[i].TenLoai = row["TenLoai"].ToString();
                    loaisach[i].DaXoa = int.Parse(row["DaXoa"].ToString());
                    i++;
                }
                return loaisach;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool Insert(LoaiSachInfo loaisach)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into LOAISACH values(@MaLoai, @TenLoai, @DaXoa)";
                cmd.Parameters.Add("@MaLoai", SqlDbType.Int);
                cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar);
                cmd.Parameters.Add("@DaXoa", SqlDbType.Int);

                cmd.Parameters["@MaLoai"].Value = loaisach.MaLoai;
                cmd.Parameters["@TenLoai"].Value = loaisach.TenLoai;
                cmd.Parameters["@DaXoa"].Value = loaisach.DaXoa;
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
                cmd.CommandText = @"Select * from LOAISACH order by MaLoai desc";
                int max = Int32.Parse(GetMax(cmd, "MaLoai"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public LoaiSachInfo[] TimMaHD(string madon)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from LOAISACH where MaLoai = " + madon;
                dt = GetTable(cmd, "LOAISACH");
                LoaiSachInfo[] loaisach = new LoaiSachInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    loaisach[i] = new LoaiSachInfo();
                    loaisach[i].MaLoai = int.Parse(row["MaLoai"].ToString());
                    loaisach[i].TenLoai = row["TenLoai"].ToString();
                    loaisach[i].DaXoa = int.Parse(row["DaXoa"].ToString());
                    i++;
                }
                return loaisach;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool Update(LoaiSachInfo dvt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Update LOAISACH set MaLoai = @MaLoai, TenLoai = @TenLoai, DaXoa = @DaXoa where MaLoai = @MaLoai";
                cmd.Parameters.Add("@MaLoai", SqlDbType.Char, 10);
                cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@DaXoa", SqlDbType.Int);

                cmd.Parameters["@MaLoai"].Value = dvt.MaLoai;
                cmd.Parameters["@TenLoai"].Value = dvt.TenLoai;
                cmd.Parameters["@DaXoa"].Value = dvt.DaXoa;
                return Update(cmd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public LoaiSachInfo GetOne(int maloaisach)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from LOAISACH where MaLoai = " + maloaisach.ToString();
                dt = GetTable(cmd, "LOAISACH");
                LoaiSachInfo loaisach = new LoaiSachInfo();
                loaisach.MaLoai = int.Parse(dt.Rows[0]["MaLoai"].ToString());
                loaisach.TenLoai = dt.Rows[0]["TenLoai"].ToString();
                loaisach.DaXoa = int.Parse(dt.Rows[0]["DaXoa"].ToString());
                return loaisach;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
    }
}
