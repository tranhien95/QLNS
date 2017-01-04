using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    public class NCCInfo
    {
        private int maNCC;
        private string tenNCC;
        float chietKhau;
        int daXoa;

        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        public float ChietKhau
        {
            get { return chietKhau; }
            set { chietKhau = value; }
        }

        public int DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }

    }
}
