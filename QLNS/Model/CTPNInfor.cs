using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class CTPNInfor
    {
        private int maCTPN;
        private int maPN;
        private string maSP;
        private int soLuong;
        private long giaUocTinh;

        public int MaCTPN
        {
            get { return maCTPN; }
            set { maCTPN = value; }
        }

        public int MaPN
        {
            get { return maPN; }
            set { maPN = value; }
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

        public long GiaUocTinh
        {
            get { return giaUocTinh; }
            set { giaUocTinh = value; }
        }
    }
}
