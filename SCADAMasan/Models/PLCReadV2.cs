using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCADAMasan.Models
{
    public class PLCReadV2
    {
        private static PLCReadV2 _ins;
        public static PLCReadV2 Ins { get { if (_ins == null) _ins = new PLCReadV2(); return _ins; } set => _ins = value; }

        //Line 1
        public int SanLuong11 { set; get; } = 123;
        public int SoGoiCan11 { set; get; } = 10;
        public int SoGoiRong11 { set; get; } = 5;

        public int SanLuong12 { set; get; } = 123;
        public int SoGoiCan12 { set; get; } = 10;
        public int SoGoiRong12 { set; get; } = 5;

        public int SanLuong13 { set; get; } = 123;
        public int SoGoiCan13 { set; get; } = 10;
        public int SoGoiRong13 { set; get; } = 5;

        public int SanLuong14 { set; get; } = 123;
        public int SoGoiCan14 { set; get; } = 10;
        public int SoGoiRong14 { set; get; } = 5;

        //#region
        ////Line 2
        //public int SanLuong21 { set; get; } = 123;
        //public int SoGoiCan21 { set; get; } = 10;
        //public int SoGoiRong21 { set; get; } = 5;

        //public int SanLuong22 { set; get; } = 123;
        //public int SoGoiCan22 { set; get; } = 10;
        //public int SoGoiRong22 { set; get; } = 5;

        //public int SanLuong23 { set; get; } = 123;
        //public int SoGoiCan23 { set; get; } = 10;
        //public int SoGoiRong23 { set; get; } = 5;

        //public int SanLuong24 { set; get; } = 123;
        //public int SoGoiCan24 { set; get; } = 10;
        //public int SoGoiRong24 { set; get; } = 5;

        ////Line 3
        //public int SanLuong31 { set; get; } = 123;
        //public int SoGoiCan31 { set; get; } = 10;
        //public int SoGoiRong31 { set; get; } = 5;

        //public int SanLuong32 { set; get; } = 123;
        //public int SoGoiCan32 { set; get; } = 10;
        //public int SoGoiRong32 { set; get; } = 5;

        //public int SanLuong33 { set; get; } = 123;
        //public int SoGoiCan33 { set; get; } = 10;
        //public int SoGoiRong33 { set; get; } = 5;

        //public int SanLuong34 { set; get; } = 123;
        //public int SoGoiCan34 { set; get; } = 10;
        //public int SoGoiRong34 { set; get; } = 5;

        ////Line 4
        //public int SanLuong41 { set; get; } = 123;
        //public int SoGoiCan41 { set; get; } = 10;
        //public int SoGoiRong41 { set; get; } = 5;

        //public int SanLuong42 { set; get; } = 123;
        //public int SoGoiCan42 { set; get; } = 10;
        //public int SoGoiRong42 { set; get; } = 5;

        //public int SanLuong43 { set; get; } = 123;
        //public int SoGoiCan43 { set; get; } = 10;
        //public int SoGoiRong43 { set; get; } = 5;

        //public int SanLuong44 { set; get; } = 123;
        //public int SoGoiCan44 { set; get; } = 10;
        //public int SoGoiRong44 { set; get; } = 5;
        //#endregion
    }
}