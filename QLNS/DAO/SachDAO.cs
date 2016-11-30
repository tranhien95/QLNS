using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.Model;
using System.Data;
using System.Data.SqlClient;

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
                    sach[i].Gia = long.Parse(row["Gia"].ToString());
                    sach[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    sach[i].MaNCC = int.Parse(row["MaNCC"].ToString());
                    sach[i].LanTaiBan = int.Parse(row["LanTaiBan"].ToString());
                    sach[i].MaLoai = int.Parse(row["MaLoai"].ToString());
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
    }
}
