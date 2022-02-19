using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCADAMasan.Models
{
    public class PLCRead
    {
        private static PLCRead _ins;
        public static PLCRead Ins { get { if (_ins == null) _ins = new PLCRead(); return _ins; } set => _ins = value; }

        //Line 1
        public string SanLuong11 { set; get; } = "123";
        public string SoGoiCan11 { set; get; } = "10";
        public string SoGoiRong11 { set; get; } = "5";
        
        public string SanLuong12 { set; get; } = "123";
        public string SoGoiCan12 { set; get; } = "10";
        public string SoGoiRong12 { set; get; } = "5";

        public string SanLuong13 { set; get; } = "123";
        public string SoGoiCan13 { set; get; } = "10";
        public string SoGoiRong13 { set; get; } = "5";

        public string SanLuong14 { set; get; } = "123";
        public string SoGoiCan14 { set; get; } = "10";
        public string SoGoiRong14 { set; get; } = "5";


        //Line 2
        public string SanLuong21 { set; get; } = "123";
        public string SoGoiCan21 { set; get; } = "10";
        public string SoGoiRong21 { set; get; } = "5";

        public string SanLuong22 { set; get; } = "123";
        public string SoGoiCan22 { set; get; } = "10";
        public string SoGoiRong22 { set; get; } = "5";

        public string SanLuong23 { set; get; } = "123";
        public string SoGoiCan23 { set; get; } = "10";
        public string SoGoiRong23 { set; get; } = "5";

        public string SanLuong24 { set; get; } = "123";
        public string SoGoiCan24 { set; get; } = "10";
        public string SoGoiRong24 { set; get; } = "5";

        //Line 3
        public string SanLuong31 { set; get; } = "123";
        public string SoGoiCan31 { set; get; } = "10";
        public string SoGoiRong31 { set; get; } = "5";

        public string SanLuong32 { set; get; } = "123";
        public string SoGoiCan32 { set; get; } = "10";
        public string SoGoiRong32 { set; get; } = "5";

        public string SanLuong33 { set; get; } = "123";
        public string SoGoiCan33 { set; get; } = "10";
        public string SoGoiRong33 { set; get; } = "5";

        public string SanLuong34 { set; get; } = "123";
        public string SoGoiCan34 { set; get; } = "10";
        public string SoGoiRong34 { set; get; } = "5";

        //Line 4
        public string SanLuong41 { set; get; } = "123";
        public string SoGoiCan41 { set; get; } = "10";
        public string SoGoiRong41 { set; get; } = "5";

        public string SanLuong42 { set; get; } = "123";
        public string SoGoiCan42 { set; get; } = "10";
        public string SoGoiRong42 { set; get; } = "5";

        public string SanLuong43 { set; get; } = "123";
        public string SoGoiCan43 { set; get; } = "10";
        public string SoGoiRong43 { set; get; } = "5";

        public string SanLuong44 { set; get; } = "123";
        public string SoGoiCan44 { set; get; } = "10";
        public string SoGoiRong44 { set; get; } = "5";
    }
}