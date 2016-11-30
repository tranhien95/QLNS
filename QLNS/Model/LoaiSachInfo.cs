using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    class LoaiSachInfo
    {
        private int maLoai;
        private string tenLoai;

        public int MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }
    }
}
