using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class PhieuNhapInfo
    {
        private int maPhieu;
        private DateTime ngayLap;
        private int trangThai;
        private long chiPhiUocTinh;

        public int MaPhieu
        {
            get { return maPhieu; }
            set { maPhieu = value; }
        }

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public long ChiPhiUocTinh
        {
            get { return chiPhiUocTinh; }
            set { chiPhiUocTinh = value; }
        }

    }
}
