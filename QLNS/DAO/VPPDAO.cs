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
    class VPPDAO : BaseDAO
    {

        public VanPhongPhamInfo[] SelectAll()
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from VANPHONGPHAM";
                DataTable dt = GetTable(cmd, "VANPHONGPHAM");
                VanPhongPhamInfo[] vpp = new VanPhongPhamInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    vpp[i] = new VanPhongPhamInfo();
                    vpp[i].MaVPP = row["MaVPP"].ToString();
                    vpp[i].TenVPP = row["TenVPP"].ToString();
                    vpp[i].Gia = double.Parse(row["Gia"].ToString());
                    vpp[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    vpp[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                    vpp[i].DaXoa = int.Parse(row["DaXoa"].ToString());
                    vpp[i].MaDVT = int.Parse(row["MaDVT"].ToString());
                    vpp[i].TenNSX = row["TenNSX"].ToString();
                    //Thêm một số thuộc tính
                    i++;
                }
                return vpp;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool Insert(VanPhongPhamInfo vpp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into VANPHONGPHAM values(@MaVPP, @TenVPP, @Gia, @SoLuong, @MaDVT, @MaNCC, @TenNSX, @DaXoa)";
                cmd.Parameters.Add("@MaVPP", SqlDbType.Int);
                cmd.Parameters.Add("@TenVPP", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Gia", SqlDbType.Money);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmd.Parameters.Add("@MaDVT", SqlDbType.Int);
                cmd.Parameters.Add("@MaNCC", SqlDbType.Int);
                cmd.Parameters.Add("@TenNSX", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@DaXoa", SqlDbType.Int);
                
                cmd.Parameters["@MaVPP"].Value = vpp.MaVPP;
                cmd.Parameters["@TenVPP"].Value = vpp.TenVPP;
                cmd.Parameters["@Gia"].Value = vpp.Gia;
                cmd.Parameters["@Soluong"].Value = vpp.SoLuong;
                cmd.Parameters["@MaDVT"].Value = vpp.MaDVT;
                cmd.Parameters["@MaNCC"].Value = vpp.MaNCC;
                cmd.Parameters["@TenNSX"].Value = vpp.TenNSX;
                cmd.Parameters["@DaXoa"].Value = vpp.DaXoa;
                
               
                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool Update(VanPhongPhamInfo vpp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Update VANPHONGPHAM set MaVPP = @MaVPP, TenVPP = @TenVPP, Gia = @Gia, SoLuong = @SoLuong, MaDVT = @MaDVT, MaNCC = @MaNCC, TenNSX = @TenNSX, DaXoa = @DaXoa where MaDVT = @MaDVT";
                cmd.Parameters.Add("@MaVPP", SqlDbType.Int);
                cmd.Parameters.Add("@TenVPP", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Gia", SqlDbType.Money);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmd.Parameters.Add("@MaDVT", SqlDbType.Int);
                cmd.Parameters.Add("@MaNCC", SqlDbType.Int);
                cmd.Parameters.Add("@TenNSX", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@DaXoa", SqlDbType.Int);

                cmd.Parameters["@MaVPP"].Value = vpp.MaVPP;
                cmd.Parameters["@TenVPP"].Value = vpp.TenVPP;
                cmd.Parameters["@Gia"].Value = vpp.Gia;
                cmd.Parameters["@Soluong"].Value = vpp.SoLuong;
                cmd.Parameters["@MaDVT"].Value = vpp.MaDVT;
                cmd.Parameters["@MaNCC"].Value = vpp.MaNCC;
                cmd.Parameters["@TenNSX"].Value = vpp.TenNSX;
                cmd.Parameters["@DaXoa"].Value = vpp.DaXoa;
                return Update(cmd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int SelectMaxVPP()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from VANPHONGPHAM order by MaVPP desc";
                int max = Int32.Parse(GetMax(cmd, "MaVPP"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public VanPhongPhamInfo[] TimMaVPP(string madon)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from VANPHONGPHAM where MaVPP = " + madon;
                dt = GetTable(cmd, "VANPHONGPHAM");
                VanPhongPhamInfo[] vpp = new VanPhongPhamInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    vpp[i] = new VanPhongPhamInfo();
                    vpp[i].MaVPP = row["MaVPP"].ToString();
                    vpp[i].TenVPP = row["TenVPP"].ToString();
                    vpp[i].Gia = double.Parse(row["Gia"].ToString());
                    vpp[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    vpp[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                    vpp[i].DaXoa = int.Parse(row["DaXoa"].ToString());
                    vpp[i].MaDVT = int.Parse(row["MaDVT"].ToString());
                    vpp[i].TenNSX = row["TenNSX"].ToString();
                    i++;
                }
                return vpp;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public VanPhongPhamInfo GetOne(int mavpp)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from VANPHONGPHAM where MaVPP = " + mavpp.ToString();
                dt = GetTable(cmd, "VANPHONGPHAM");
                VanPhongPhamInfo vpp = new VanPhongPhamInfo();
                vpp.MaVPP = dt.Rows[0]["MaVPP"].ToString();
                vpp.TenVPP = dt.Rows[0]["TenVPP"].ToString();
                vpp.Gia = double.Parse(dt.Rows[0]["Gia"].ToString());
                vpp.SoLuong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
                vpp.MaNCC = int.Parse(dt.Rows[0]["MaNCC"].ToString());
                vpp.DaXoa = int.Parse(dt.Rows[0]["DaXoa"].ToString());
                vpp.MaDVT = int.Parse(dt.Rows[0]["MaDVT"].ToString());
                vpp.TenNSX = dt.Rows[0]["TenNSX"].ToString();
                return vpp;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
    }
}
