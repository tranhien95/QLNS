using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    public class HoaDonNhapInfo
    {
        private int maHDN;
        private int maPhieuNhap;
        private DateTime ngayLap;
        private double thanhTien;

        public int MaHDN
        {
            get { return maHDN; }
            set { maHDN = value; }
        }

        public int MaPN
        {
            get { return maPhieuNhap; }
            set { maPhieuNhap = value; }
        }

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public double ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

    }
}
