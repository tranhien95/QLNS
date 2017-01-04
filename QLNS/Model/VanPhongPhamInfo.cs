using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    public class VanPhongPhamInfo
    {
        private string maVPP;
        private string tenVPP;
        private string tenNSX;
        private double gia;
        private int soLuong;
        private int maNCC;
        private int daXoa;
        private int maDVT;

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

        public double Gia
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

        public int DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }

        public int MaDVT
        {
            get { return maDVT; }
            set { maDVT = value; }
        }

        public string TenNSX
        {
            get { return tenNSX; }
            set { tenNSX = value; }
        }
    }
}
