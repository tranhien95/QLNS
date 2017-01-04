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
    class VPPDAO : BaseDAO
    {

        public VanPhongPhamInfo[] SelectAll()
        {
            VanPhongPhamInfo[] vpp = new VanPhongPhamInfo[100];
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from VANPHONGPHAM";
                DataTable dt = GetTable(cmd, "VANPHONGPHAM");
                foreach (DataRow row in dt.Rows)
                {
                    vpp[i] = new VanPhongPhamInfo();
                    vpp[i].MaVPP = row["MaVPP"].ToString();
                    vpp[i].TenVPP = row["TenVPP"].ToString();
                    float gia = float.Parse(row["Gia"].ToString());
                    vpp[i].Gia = (long)(gia);
                    vpp[i].SoLuong = int.Parse(row["SoLuong"].ToString());
                    vpp[i].MaNCC = int.Parse(row["MaNCC"].ToString());
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
    }
}
