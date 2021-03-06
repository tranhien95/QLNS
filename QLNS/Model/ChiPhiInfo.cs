﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    public class ChiPhiInfo
    {
        private int maCP;
        private string tenCP;
        private DateTime ngayLap;
        private double soTien;

        public int MaCP
        {
            get { return maCP; }
            set { maCP = value; }
        }

        public string TenCP
        {
            get { return tenCP; }
            set { tenCP = value; }
        }

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public double SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }

    }
}
