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
    class NCCDAO:BaseDAO
    {

        //Lấy hết bảng NCC
        public DataTable SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from NCC Where DaXoa = 0";
                dt = GetTable(cmd, "NCC");
                //NCCInfo[] ncc = new NCCInfo[dt.Rows.Count];
                //foreach (DataRow row in dt.Rows)
                //{
                //    ncc[i] = new NCCInfo();
                //    ncc[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                //    ncc[i].TenNCC = row["TenNCC"].ToString();
                //    ncc[i].ChietKhau = float.Parse(row["ChietKhau"].ToString());
                //    ncc[i].DaXoa = int.Parse(row["DaXoa"].ToString());
                //    i++;
                //}
                //return ncc;
                return dt;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        //Thêm dữ liệu vào bảng NCC
        public bool Insert(NCCInfo ncc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into NCC values(@MaNCC, @TenNCC, @ChietKhau, @DaXoa)";
                cmd.Parameters.Add("@MaNCC", SqlDbType.Int);
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@ChietKhau", SqlDbType.Float);
                cmd.Parameters.Add("@SoLuongDoi", SqlDbType.Int);

                cmd.Parameters["@MaNCC"].Value = ncc.MaNCC;
                cmd.Parameters["@TenNCC"].Value = ncc.TenNCC;
                cmd.Parameters["@ChietKhau"].Value = ncc.ChietKhau;
                cmd.Parameters["@DaXoa"].Value = ncc.DaXoa;
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

        //Update bảng NCC
        public bool Update(NCCInfo ncc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Update NCC set MaNCC = @MaNCC, TenNCC = @TenNCC, ChietKhau = @ChietKhau, DaXoa = @DaXoa where MaNCC = @MaNCC";
                cmd.Parameters.Add("@MaNCC", SqlDbType.Int);
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@ChietKhau", SqlDbType.Float);
                cmd.Parameters.Add("@SoLuongDoi", SqlDbType.Int);

                cmd.Parameters["@MaNCC"].Value = ncc.MaNCC;
                cmd.Parameters["@TenNCC"].Value = ncc.TenNCC;
                cmd.Parameters["@ChietKhau"].Value = ncc.ChietKhau;
                cmd.Parameters["@DaXoa"].Value = ncc.DaXoa;
                return Update(cmd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Lấy ra mã NCC lớn nhất
        public int SelectMaxNCC()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from NCC order by MaNCC desc";
                int max = Int32.Parse(GetMax(cmd, "MaNCC"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        //Tìm thông tin NCC theo tên
        public NCCInfo[] TimTenNCC(string ten)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from NCC where TenNCC like N'%" + ten + "%'";
                dt = GetTable(cmd, "NCC");
                NCCInfo[] ncc = new NCCInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    ncc[i] = new NCCInfo();
                    ncc[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                    ncc[i].TenNCC = row["TenNCC"].ToString();
                    ncc[i].ChietKhau = float.Parse(row["ChietKhau"].ToString());
                    ncc[i].DaXoa = int.Parse(row["DaXoa"].ToString());
                    i++;
                }
                return ncc;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        //Lấy 1 NCC dựa trên mã của nó
        public NCCInfo GetOne(int mancc)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from NCC where MaNCC = " + mancc.ToString();
                dt = GetTable(cmd, "NCC");
                NCCInfo ncc = new NCCInfo();
                ncc.MaNCC = int.Parse(dt.Rows[0]["MaNCC"].ToString());
                ncc.TenNCC = dt.Rows[0]["TenNCC"].ToString();
                ncc.ChietKhau = float.Parse(dt.Rows[0]["ChietKhau"].ToString());
                ncc.DaXoa = Int32.Parse(dt.Rows[0]["DaXoa"].ToString());
                return ncc;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

    }
}
