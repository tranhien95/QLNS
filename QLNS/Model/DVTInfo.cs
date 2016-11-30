using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class DVTInfo
    {
        private int maDVT;
        private string tenDVT;
        private string maVPPLe;
        private int soLuongDoi;

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

        public string MaVPPLe
        {
            get { return maVPPLe; }
            set { maVPPLe = value; }
        }

    }
}
