using SCADAMasan.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCADAMasan.Models
{
    public class DataProvider
    {
        private static DataProvider _ins;
        public static DataProvider Ins { get { if (_ins == null) _ins = new DataProvider(); return _ins; } set => _ins = value; }

        public SCADAMasanHDEntities DB { get; set; }
        private DataProvider()
        {
            DB = new SCADAMasanHDEntities();
        }
    }
}