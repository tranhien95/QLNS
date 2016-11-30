using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class HoaDonInfo
    {
        private int maDon;
        private DateTime ngayLap;
        private long tongTien;

        public int MaDon
        {
            get { return maDon; }
            set { maDon = value; }
        }

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public long TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

    }
}
