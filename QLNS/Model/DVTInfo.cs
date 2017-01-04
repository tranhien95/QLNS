using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    public class DVTInfo
    {
        private int maDVT;
        private string tenDVT;
        private string maVPPChan;
        private int soLuongDoi;
        private int daXoa;

        public int MaDVT
        {
            get { return maDVT; }
            set { maDVT = value; }
        }

        public string TenDVT
        {
            get { return tenDVT; }
            set { tenDVT = value; }
        }

        public int SoLuongDoi
        {
            get { return soLuongDoi; }
            set { soLuongDoi = value; }
        }

        public string MaVPPChan
        {
            get { return maVPPChan; }
            set { maVPPChan = value; }
        }

        public int DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }

    }
}
