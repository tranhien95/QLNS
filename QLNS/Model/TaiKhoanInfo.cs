using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QLNS.Model
{
    public class TaiKhoanInfo
    {
        private string iD;
        private string pass;
        private int loaiTK;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Pass
        {
            get { return pass; }
            set
            {
                MD5 md5Hash = MD5.Create();
                pass = GetMd5Hash(md5Hash, value);
            }
        }

        public int LoaiTK
        {
            get { return loaiTK; }
            set { loaiTK = value; }
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
