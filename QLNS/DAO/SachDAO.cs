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
    class SachDAO:BaseDAO
    {

        public SachInfo[] SelectAll()
        {
            SachInfo[] sach = new SachInfo[100];
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from SACH";
                DataTable dt = GetTable(cmd, "SACH");
                foreach (DataRow row in dt.Rows)
                {
                    sach[i] = new SachInfo();
                    sach[i].MaSach = row["MaSach"].ToString();
                    sach[i].TenSach = row["TenSach"].ToString();
                    sach[i].TacGia = row["TacGia"].ToString();
                    sach[i].Gia = double.Parse(row["Gia"].ToString());
                    sach[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    sach[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                    sach[i].LanTaiBan = int.Parse(row["LanTaiBan"].ToString());
                    sach[i].MaLoai = int.Parse(row["MaLoai"].ToString());
                    sach[i].DaXoa = int.Parse(row["DaXoa"].ToString());
                    //Thêm một số thuộc tính
                    i++;
                }
                return sach;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool Insert(SachInfo sach)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into SACH values(@MaSach, @TenSach, @Gia, @SoLuong, @TacGia, @MaNCC, @LanTaiBan, @MaLoai, @DaXoa)";
                cmd.Parameters.Add("@MaSach", SqlDbType.Int);
                cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Gia", SqlDbType.Money);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MaNCC", SqlDbType.Int);
                cmd.Parameters.Add("@LanTaiBan", SqlDbType.Int);
                cmd.Parameters.Add("@MaLoai", SqlDbType.Int);
                cmd.Parameters.Add("@DaXoa", SqlDbType.Int);

                cmd.Parameters["@MaSach"].Value = sach.MaSach;
                cmd.Parameters["@TenSach"].Value = sach.TenSach;
                cmd.Parameters["@Gia"].Value = sach.Gia;
                cmd.Parameters["@Soluong"].Value = sach.SoLuong;
                cmd.Parameters["@TacGia"].Value = sach.TacGia;
                cmd.Parameters["@MaNCC"].Value = sach.MaNCC;
                cmd.Parameters["@LanTaiBan"].Value = sach.LanTaiBan;
                cmd.Parameters["@DaXoa"].Value = sach.DaXoa;


                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool Update(SachInfo sach)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Update SACH set MaSach = @MaSach, TenSach = @TenSach, Gia = @Gia, SoLuong = @SoLuong, TacGia = @TacGia, MaNCC = @MaNCC, LanTaiBan = @LanTaiBan, MaLoai = @MaLoai, DaXoa = @DaXoa where MaDVT = @MaDVT";
                cmd.CommandText = @"Insert Into SACH values(@MaSach, @TenSach, @Gia, @SoLuong, @TacGia, @MaNCC, @LanTaiBan, @MaLoai, @DaXoa)";
                cmd.Parameters.Add("@MaSach", SqlDbType.Int);
                cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Gia", SqlDbType.Money);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MaNCC", SqlDbType.Int);
                cmd.Parameters.Add("@LanTaiBan", SqlDbType.Int);
                cmd.Parameters.Add("@MaLoai", SqlDbType.Int);
                cmd.Parameters.Add("@DaXoa", SqlDbType.Int);

                cmd.Parameters["@MaSach"].Value = sach.MaSach;
                cmd.Parameters["@TenSach"].Value = sach.TenSach;
                cmd.Parameters["@Gia"].Value = sach.Gia;
                cmd.Parameters["@Soluong"].Value = sach.SoLuong;
                cmd.Parameters["@TacGia"].Value = sach.TacGia;
                cmd.Parameters["@MaNCC"].Value = sach.MaNCC;
                cmd.Parameters["@LanTaiBan"].Value = sach.LanTaiBan;
                cmd.Parameters["@DaXoa"].Value = sach.DaXoa;
                return Update(cmd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int SelectMaxSach()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from SACH order by MaSach desc";
                int max = Int32.Parse(GetMax(cmd, "MaSach"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public SachInfo[] TimMaSach(string madon)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from SACH where MaSach = " + madon;
                dt = GetTable(cmd, "SACH");
                SachInfo[] sach = new SachInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    sach[i] = new SachInfo();
                    sach[i].MaSach = row["MaSach"].ToString();
                    sach[i].TenSach = row["TenSach"].ToString();
                    sach[i].TacGia = row["TacGia"].ToString();
                    sach[i].Gia = double.Parse(row["Gia"].ToString());
                    sach[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    sach[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                    sach[i].LanTaiBan = int.Parse(row["LanTaiBan"].ToString());
                    sach[i].MaLoai = int.Parse(row["MaLoai"].ToString());
                    sach[i].DaXoa = int.Parse(row["DaXoa"].ToString());
                    i++;
                }
                return sach;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public SachInfo GetOne(int masach)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from SACH where MaSach = " + masach.ToString();
                dt = GetTable(cmd, "SACH");
                SachInfo sach = new SachInfo();
                sach.MaSach = dt.Rows[0]["MaSach"].ToString();
                sach.TenSach = dt.Rows[0]["TenSach"].ToString();
                sach.Gia = double.Parse(dt.Rows[0]["Gia"].ToString());
                sach.SoLuong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
                sach.MaNCC = int.Parse(dt.Rows[0]["MaNCC"].ToString());
                sach.DaXoa = int.Parse(dt.Rows[0]["DaXoa"].ToString());
                sach.TacGia = dt.Rows[0]["TacGia"].ToString();
                sach.LanTaiBan = int.Parse(dt.Rows[0]["TenNSX"].ToString());
                sach.MaLoai = int.Parse(dt.Rows[0]["MaLoai"].ToString());
                return sach;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public DataTable TimSachTheoNCC(int mancc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from SACH Where DaXoa = 0 AND MaNCC = " + mancc;
                DataTable dt = GetTable(cmd, "SACH");
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
