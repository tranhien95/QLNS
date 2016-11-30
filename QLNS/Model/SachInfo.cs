using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class SachInfo
    {
        private string maSach;
        private string tenSach;
        private string tacGia;
        private long gia;
        private int soLuong;
        private int maNCC;
        private int lanTaiBan;
        private int maLoai;
        private string maSachTT;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
       
        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
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

        public int LanTaiBan
        {
            get { return lanTaiBan; }
            set { lanTaiBan = value; }
        }

        public int MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        public string MaSachTT
        {
            get { return maSachTT; }
            set { maSachTT = value; }
        }
    }
}
