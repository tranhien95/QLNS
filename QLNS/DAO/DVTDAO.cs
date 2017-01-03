﻿using System;
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
    class DVTDAO:BaseDAO
    {
        //Lấy hết bảng DVT
        public DVTInfo[] SelectAll()
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from DVT";
                dt = GetTable(cmd, "DVT");
                DVTInfo[] dvt = new DVTInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    dvt[i] = new DVTInfo();
                    dvt[i].MaDVT = int.Parse(row["MaDVT"].ToString());
                    dvt[i].TenDVT = row["TenDVT"].ToString();
                    dvt[i].MaVPPLe = row["MaVPPLe"].ToString();
                    dvt[i].SoLuongDoi = Int32.Parse(row["SoLuongDoi"].ToString());
                    i++;
                }
                return dvt;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        //Thêm dữ liệu vào bảng DVT
        public bool Insert(DVTInfo dvt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into DVT values(@MaDVT, @TenDVT, @MaVPPLe, @SoLuongDoi)";
                cmd.Parameters.Add("@MaDVT", SqlDbType.Char, 10);
                cmd.Parameters.Add("@TenDVT", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MaVPPLe", SqlDbType.Char, 10);
                cmd.Parameters.Add("@SoLuongDoi", SqlDbType.Int);

                cmd.Parameters["@MaDVT"].Value = dvt.MaDVT;
                cmd.Parameters["@TenDVT"].Value = dvt.TenDVT;
                cmd.Parameters["@MaVPPLe"].Value = dvt.MaVPPLe;
                cmd.Parameters["@SoLuongDoi"].Value = dvt.SoLuongDoi;
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

        //Update bảng DVT
        public bool Update(DVTInfo dvt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Update DVT set MaDVT = @MaDVT, TenDVT = @TenDVT, MaVPPLe = @MaVPPLe, SoLuongDoi = @SoLuongDoi where MaDVT = @MaDVT";
                cmd.Parameters.Add("@MaDVT", SqlDbType.Char, 10);
                cmd.Parameters["@MaDVT"].Value = dvt.MaDVT;
                cmd.Parameters.Add("@TenDVT", SqlDbType.NVarChar, 50);
                cmd.Parameters["@TenDVT"].Value = dvt.TenDVT;
                cmd.Parameters.Add("@MaVPPLe", SqlDbType.Char, 10);
                cmd.Parameters["@MaVPPLe"].Value = dvt.MaVPPLe;
                cmd.Parameters.Add("@SoLuongDoi", SqlDbType.Int);
                cmd.Parameters["@SoLuongDoi"].Value = dvt.SoLuongDoi;
                return Update(cmd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Lấy ra mã DVT lớn nhất
        public int SelectMaxDVT()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from DVT order by MaDVT desc";
                int max = Int32.Parse(GetMax(cmd, "MaDVT"));
                if (max == null) max = 0;
                return max;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        //Tìm thông tin DVT theo tên
        public DVTInfo[] TimTenDVT(string ten)
        {
            DataTable dt;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from DVT where TenDVT like N'%" + ten + "%'";
                dt = GetTable(cmd, "DVT");
                DVTInfo[] dvt = new DVTInfo[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    dvt[i] = new DVTInfo();
                    dvt[i].MaDVT = int.Parse(row["MaDVT"].ToString());
                    dvt[i].TenDVT = row["TenDVT"].ToString();
                    dvt[i].MaVPPLe = row["MaVPPLe"].ToString();
                    dvt[i].SoLuongDoi = Int32.Parse(row["SoLuongDoi"].ToString());
                    i++;
                }
                return dvt;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        //Lấy 1 DVT dựa trên mã của nó
        public DVTInfo GetOne(int madvt)
        {
            DataTable dt;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * from DVT where MaDVT = " + madvt.ToString();
                dt = GetTable(cmd, "DVT");
                DVTInfo dvt = new DVTInfo();
                dvt.MaDVT = int.Parse(dt.Rows[0]["MaDVT"].ToString());
                dvt.TenDVT = dt.Rows[0]["TenDVT"].ToString();
                dvt.MaVPPLe = dt.Rows[0]["MaVPPLe"].ToString();
                dvt.SoLuongDoi = Int32.Parse(dt.Rows[0]["SoLuongDoi"].ToString());
                return dvt;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

    }
}
