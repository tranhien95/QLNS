using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    public class PhieuNhapInfo
    {
        private int maPhieu;
        private DateTime ngayLap;
        private int trangThai;
        private double chiPhiUocTinh;
        private int maNCC;

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

        public double ChiPhiUocTinh
        {
            get { return chiPhiUocTinh; }
            set { chiPhiUocTinh = value; }
        }

        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

    }
}
