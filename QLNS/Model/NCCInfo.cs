using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class NCCInfo
    {
        private int maNCC;
        private string tenNCC;
        private string maVPPLe;
        private int soLuongDoi;

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
