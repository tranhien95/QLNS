using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class HoaHDNNhapInfo
    {
        private int maHDN;
        private int maNCC;
        private DateTime ngayLap;
        private long thanhTien;

        public int MaHDN
        {
            get { return maHDN; }
            set { maHDN = value; }
        }

        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public long ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

    }
}
