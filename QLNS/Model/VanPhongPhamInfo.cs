using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class VanPhongPhamInfo
    {
        private string maVPP;
        private string tenVPP;
        private long gia;
        private int soLuong;
        private int maNCC;
        private string maVPPTT;

        public string MaVPP
        {
            get { return maVPP; }
            set { maVPP = value; }
        }

        public string TenVPP
        {
            get { return tenVPP; }
            set { tenVPP = value; }
        }

        public long Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string MaVPPTT
        {
            get { return maVPPTT; }
            set { maVPPTT = value; }
        }
    }
}
