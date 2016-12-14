using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.DAO;
using QLNS.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QLNS.Services
{
    class LogIn
    {
        private TaiKhoanDAO AccDAO;
        public LogIn()
        {
            AccDAO = new TaiKhoanDAO();
        }
        public bool CheckAcc(TaiKhoanInfo AccInfo)
        {
            DataTable dt = AccDAO.GetSingle(AccInfo.ID);
            if(dt != null && dt.Rows[0] != null)
            {
                if(dt.Rows[0].Field<string>("ID") == AccInfo.ID)
                {
                    return true;
                }
            }
            return false;
        }

        public int CheckPass(TaiKhoanInfo AccInfo)
        {
            DataTable dt = AccDAO.GetSingle(AccInfo.ID);
            MD5 md5Hash = MD5.Create();
            //string PassMd5 = GetMd5Hash(md5Hash, AccInfo.Pass);
            if(dt != null&&dt.Rows.Count>0)
            {
                string SourcePass = dt.Rows[0].Field<string>("Pass");
                int LoaiTK = dt.Rows[0].Field<int>("LoaiTK");
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                if (0 == comparer.Compare(AccInfo.Pass, SourcePass))
                {
                    return LoaiTK;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        private string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            } 
            return sBuilder.ToString();
        }
    }
}
