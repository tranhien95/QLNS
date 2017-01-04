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
    class ChiPhiDAO:BaseDAO
    {
        public ChiPhiInfo[] SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CHIPHI";
                dt = GetTable(cmd, "CHIPHI");
                ChiPhiInfo[] cp = new ChiPhiInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    cp[i] = new ChiPhiInfo();
                    cp[i].MaCP = int.Parse(row["MaCP"].ToString());
                    cp[i].TenCP = row["TenCP"].ToString();
                    cp[i].SoTien = double.Parse(row["SoTien"].ToString());
                    cp[i].NgayLap = (DateTime)row["NgayLap"];
                    i++;
                }
                return cp;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        //Thêm dữ liệu vào bảng ChiPhi
        public bool Insert(ChiPhiInfo cp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into CHIPHI values(@MaCP, @TenCP, @SoTien, @NgayLap)";
                cmd.Parameters.Add("@MaCP", SqlDbType.Int);
                cmd.Parameters.Add("@TenCP", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@SoTien", SqlDbType.Money);
                cmd.Parameters.Add("@NgayLap", SqlDbType.SmallDateTime);

                cmd.Parameters["@MaCP"].Value = cp.MaCP;
                cmd.Parameters["@TenCP"].Value = cp.TenCP;
                cmd.Parameters["@SoTien"].Value = cp.SoTien;
                cmd.Parameters["@NgayLap"].Value = cp.NgayLap;
                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Delete
        public bool Delete(int madon)
        {
            return true;
        }

        //Update bảng ChiPhi
        public bool Update(ChiPhiInfo cp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Update CHIPHI set MaCP = @MaCP, TenCP = @TenCP, SoTien = @SoTien, NgayLap = @NgayLap where MaCP = @MaCP";
                cmd.Parameters.Add("@MaCP", SqlDbType.Int);
                cmd.Parameters["@MaCP"].Value = cp.MaCP;
                cmd.Parameters.Add("@TenCP", SqlDbType.NVarChar, 50);
                cmd.Parameters["@TenCP"].Value = cp.TenCP;
                cmd.Parameters.Add("@TongTien", SqlDbType.Money);
                cmd.Parameters["@SoTien"].Value = cp.SoTien;
                cmd.Parameters.Add("@NgayLap", SqlDbType.SmallDateTime);
                cmd.Parameters["@NgayLap"].Value = cp.NgayLap;
                return Update(cmd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Lấy ra mã ChiPhi lớn nhất
        public int SelectMaxCP()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CHIPHI order by MaCP desc";
                int max = Int32.Parse(GetMax(cmd, "MaCP"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        //Tìm thông tin ChiPhi theo tên
        public ChiPhiInfo[] TimTenCP(string ten)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from CHIPHI where TenCP like N'%" + ten + "%'";
                dt = GetTable(cmd, "ChiPhi");
                ChiPhiInfo[] cp = new ChiPhiInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    cp[i] = new ChiPhiInfo();
                    cp[i].MaCP = int.Parse(row["MaCP"].ToString());
                    cp[i].TenCP = row["TenCP"].ToString();
                    cp[i].SoTien = double.Parse(row["SoTien"].ToString());
                    cp[i].NgayLap = (DateTime)row["NgayLap"];
                    i++;
                }
                return cp;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        //Lấy 1 ChiPhi dựa trên mã của nó
        public ChiPhiInfo GetOne(int macp)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from ChiPhi where MaCP = " + macp.ToString();
                dt = GetTable(cmd, "ChiPhi");
                ChiPhiInfo cp = new ChiPhiInfo();
                cp.MaCP = int.Parse(dt.Rows[0]["MaCP"].ToString());
                cp.TenCP = dt.Rows[0]["TenCP"].ToString();
                cp.SoTien = double.Parse(dt.Rows[0]["MaVPPLe"].ToString());
                cp.NgayLap = (DateTime)dt.Rows[0]["SoLuongDoi"];
                return cp;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

    }
}
