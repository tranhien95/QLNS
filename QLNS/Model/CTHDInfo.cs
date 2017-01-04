using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    public class CTHDInfo
    {
        private int maCTHD;
        private int maHD;
        private string maSP;
        private int soLuong;
        private double tongTien;

        public int MaCTHD
        {
            get { return maCTHD; }
            set { maCTHD = value; }
        }

        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
