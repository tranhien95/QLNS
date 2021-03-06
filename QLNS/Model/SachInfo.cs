﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model
{
    public class SachInfo
    {
        private string maSach;
        private string tenSach;
        private string tacGia;
        private double gia;
        private int soLuong;
        private int maNCC;
        private int lanTaiBan;
        private int maLoai;
        private int daXoa;

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

        public double Gia
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

        public int DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }

    }
}
