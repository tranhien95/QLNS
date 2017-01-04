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
    class CTPNDAO:BaseDAO
    {
        public CTPNInfo[] SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CTPN";
                dt = GetTable(cmd, "CTPN");
                CTPNInfo[] cthd = new CTPNInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    cthd[i] = new CTPNInfo();
                    cthd[i].MaCTPN = int.Parse(row["MaCTPN"].ToString());
                    cthd[i].MaPN= int.Parse(row["MaPN"].ToString());
                    cthd[i].MaSP = row["MaSP"].ToString();
                    cthd[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    cthd[i].GiaUocTinh = double.Parse(row["GiaUocTinh"].ToString());
                    i++;
                }
                return cthd;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool Insert(CTPNInfo cthd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into CTPN values(@MaCTPN, @MaPN, @MaSP, @SoLuong, @GiaUocTinh)";
                cmd.Parameters.Add("@MaCTPN", SqlDbType.Int);
                cmd.Parameters.Add("@MaPN", SqlDbType.Int);
                cmd.Parameters.Add("@MaSP", SqlDbType.Char, 10);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmd.Parameters.Add("@GiaUocTinh", SqlDbType.Money);

                cmd.Parameters["@MaCTPN"].Value = cthd.MaCTPN;
                cmd.Parameters["@MaPN"].Value = cthd.MaPN;
                cmd.Parameters["@MaSP"].Value = cthd.MaSP;
                cmd.Parameters["@SoLuong"].Value = cthd.SoLuong;
                cmd.Parameters["@GiaUocTinh"].Value = cthd.GiaUocTinh;
                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int SelectMaxCTPN()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CTPN order by MaCTPN desc";
                int max = Int32.Parse(GetMax(cmd, "MaCTPN"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public CTPNInfo[] TimMaPN(string macthd)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CTPN where MaCTPN = " + macthd;
                dt = GetTable(cmd, "CTPN");
                CTPNInfo[] cthd = new CTPNInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    cthd[i] = new CTPNInfo();
                    cthd[i].MaCTPN = int.Parse(row["MaCTPN"].ToString());
                    cthd[i].MaPN= int.Parse(row["MaPN"].ToString());
                    cthd[i].MaSP = row["MaSP"].ToString();
                    cthd[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    cthd[i].GiaUocTinh = double.Parse(row["GiaUocTinh"].ToString());
                    i++;
                }
                return cthd;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public CTPNInfo GetOne(int macthd)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CTPN where MaCTPN = " + macthd.ToString();
                dt = GetTable(cmd, "CTPN");
                CTPNInfo cthd = new CTPNInfo();
                cthd.MaCTPN = int.Parse(dt.Rows[0]["MaCTPN"].ToString());
                cthd.MaPN= int.Parse(dt.Rows[0]["MaPN"].ToString());
                cthd.MaSP = dt.Rows[0]["MaSP"].ToString();
                cthd.SoLuong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
                cthd.GiaUocTinh = double.Parse(dt.Rows[0]["GiaUocTinh"].ToString());
                return cthd;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
    }
}
