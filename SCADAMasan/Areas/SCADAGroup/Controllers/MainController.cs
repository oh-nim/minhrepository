using SCADAMasan.Areas.SCADAGroup.Models;
using SCADAMasan.Models;
using SCADAMasan.Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace SCADAMasan.Areas.SCADAGroup.Controllers
{
    public class MainController : Controller
    {
        #region //*********************Trang chu*************************
        // GET: SCADAGroup/Main
        public ActionResult Index()
        {
            //PLC.Instance().ReadData();
            var session = (LoginModel)Session[Constants.USER_SESSION];
            ViewBag.TruongCa = session.fullname;
            ViewBag.NumberLineA = 1;
            ViewBag.NumberLineB = 2;
            return View();
        }
        public ActionResult LoadDataRealTime()
        {
            var ResultData1 = PLCReadV2.Ins;
            return Json(ResultData1, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Test
        public void VoidMethod()
        {
            ViewBag.demo1 = @ViewBag.SearchKeyword;
        }

        static int Count = 0;
        #endregion

        #region //*********************Truong ca*************************
        public ActionResult ThongTinChung()
        {
            ViewData["TruongCa"] = DataProvider.Ins.DB.TruongCas.ToList();
            ViewData["SanPham"] = DataProvider.Ins.DB.SanPhams.ToList();
            return View();
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "AddTruongCa")]
        public ActionResult AddTruongCa(string lbID1, string txtDisplayName1)
        {
            DataProvider.Ins.DB.TruongCas.Add(new TruongCa() { DisplayName = txtDisplayName1 });
            DataProvider.Ins.DB.SaveChanges();
            return RedirectToAction("ThongTinChung");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "DeleteTruongCa")]
        public ActionResult DeleteTruongCa(string lbID1, string txtDisplayName1)
        {
            TruongCa temp = DataProvider.Ins.DB.TruongCas.SingleOrDefault(x => x.DisplayName == txtDisplayName1);
            DataProvider.Ins.DB.TruongCas.Remove(temp);
            DataProvider.Ins.DB.SaveChanges();
            return RedirectToAction("ThongTinChung");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "EditTruongCa")]
        public ActionResult EditTruongCa(string lbID1, string txtDisplayName1)
        {
            var tempID = Convert.ToInt32(lbID1);
            var temp = DataProvider.Ins.DB.TruongCas.Where(x => x.Id == tempID).SingleOrDefault();
            temp.DisplayName = txtDisplayName1;
            DataProvider.Ins.DB.SaveChanges();
            return RedirectToAction("ThongTinChung");
        }
        #endregion

        #region //*********************San pham*************************
        [HttpPost]
        [MultipleButton(Name = "action", Argument = "AddSanPham")]
        public ActionResult AddSanPham(string lbID2, string txtDisplayName2)
        {
            DataProvider.Ins.DB.SanPhams.Add(new SanPham() { DisplayName = txtDisplayName2 });
            DataProvider.Ins.DB.SaveChanges();
            return RedirectToAction("ThongTinChung");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "DeleteSanPham")]
        public ActionResult DeleteSanPham(string lbID2, string txtDisplayName2)
        {
            SanPham temp = DataProvider.Ins.DB.SanPhams.SingleOrDefault(x => x.DisplayName == txtDisplayName2);
            DataProvider.Ins.DB.SanPhams.Remove(temp);
            DataProvider.Ins.DB.SaveChanges();
            return RedirectToAction("ThongTinChung");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "EditSanPham")]
        public ActionResult EditSanPham(string lbID2, string txtDisplayName2)
        {
            var tempID = Convert.ToInt32(lbID2);
            var temp = DataProvider.Ins.DB.SanPhams.Where(x => x.Id == tempID).SingleOrDefault();
            temp.DisplayName = txtDisplayName2;
            DataProvider.Ins.DB.SaveChanges();
            return RedirectToAction("ThongTinChung");
        }
        #endregion

        #region //*********************Cai dat ca san xuat*************************
        public ActionResult CaiDatCaSanXuat()
        {
            var temp = DataProvider.Ins.DB.CaiDatCaSanXuats.FirstOrDefault();
            return View(temp);
        }

        [HttpPost]
        public ActionResult SaveCaiDatCaSanXuat(CaiDatCaSanXuat tempCaiDatCaSanXuat)
        {
            var tempModel = DataProvider.Ins.DB.CaiDatCaSanXuats.Where(x => x.Id == tempCaiDatCaSanXuat.Id).SingleOrDefault();
            tempModel.TruongCa1 = tempCaiDatCaSanXuat.TruongCa1;
            tempModel.TruongCa2 = tempCaiDatCaSanXuat.TruongCa2;
            tempModel.TruongCa3 = tempCaiDatCaSanXuat.TruongCa3;
            tempModel.HourCa1 = tempCaiDatCaSanXuat.HourCa1;
            tempModel.HourCa2 = tempCaiDatCaSanXuat.HourCa2;
            tempModel.HourCa3 = tempCaiDatCaSanXuat.HourCa3;
            tempModel.MinuteCa1 = tempCaiDatCaSanXuat.MinuteCa1;
            tempModel.MinuteCa2 = tempCaiDatCaSanXuat.MinuteCa2;
            tempModel.MinuteCa3 = tempCaiDatCaSanXuat.MinuteCa3;
            DataProvider.Ins.DB.SaveChanges();
            return RedirectToAction("CaiDatCaSanXuat");
        }
        #endregion

        #region //*********************Cai dat tham so PLC*************************

        public ActionResult ThongSoPLC()
        {
            var temp = DataProvider.Ins.DB.ThongSoes.FirstOrDefault();
            return View(temp);
        }

        [HttpPost]
        public ActionResult SaveThongSoPLC(ThongSo tempThongSo)
        {
            var tempModel = DataProvider.Ins.DB.ThongSoes.Where(x => x.Id == tempThongSo.Id).SingleOrDefault();
            tempModel.TocDoChuan = tempThongSo.TocDoChuan;
            tempModel.TimeChapNhanGoi = tempThongSo.TimeChapNhanGoi;
            tempModel.TimeDayGoiCan = tempThongSo.TimeDayGoiCan;
            tempModel.TimeDungMay = tempThongSo.TimeDungMay;
            tempModel.TimeTinhGoiCan = tempThongSo.TimeTinhGoiCan;
            tempModel.TimeUpdatePLC = tempThongSo.TimeUpdatePLC;
            tempModel.TimeXilanhDayGoi = tempThongSo.TimeXilanhDayGoi;
            DataProvider.Ins.DB.SaveChanges();
            return RedirectToAction("ThongSoPLC");
        }
        #endregion

        #region //*********************Bao cao*************************

        public ActionResult BaoCao()
        {
            ViewBag.txtTimeBegin = "All";
            ViewBag.txtTimeEnd = "All";
            ViewBag.txtSanPham = "All";
            ViewBag.txtCaSanXuat = "All";
            ViewBag.txtDayChuyen = "All";
            ViewBag.txtMaySo = "All";
            var temp = DataProvider.Ins.DB.Reports.ToList();
            return View(temp);
        }

        [HttpPost]
        public ActionResult BaoCao(string txtTimeBegin, string txtTimeEnd, string txtSanPham, string txtCaSanXuat, string txtDayChuyen, string txtMaySo)
        {
            //DateTime tempTime = Convert.ToDateTime(txtTime);
            string temp1 = "";
            string temp2 = "";
            string temp3 = "";
            string temp4 = "";
            string temp5 = "";
            //string query = "SELECT * FROM[dbo].[Report] where " +
            //    "NgaySanXuat = ANY(SELECT NgaySanXuat FROM[Report]) AND " +
            //    "SanPham = ANY(SELECT SanPham FROM[Report]) AND " +
            //    "CaSanXuat = 1 AND " +
            //    "DayChuyen = ANY(SELECT DayChuyen FROM[Report]) AND " +
            //    "MaySo = ANY(SELECT MaySo FROM[Report])";

            //string query = "SELECT * FROM[dbo].[Report] where " +
            //    "NgaySanXuat = " + temp1 + " AND " +
            //    //"NgaySanXuat = ANY(SELECT NgaySanXuat FROM[Report]) AND " +
            //    "SanPham = " + temp2 + " AND " +
            //    "CaSanXuat = " + temp3 + " AND " +
            //    "DayChuyen = " + temp4 + " AND " +
            //    "MaySo = " + temp5;

            ViewBag.txtTimeBegin = txtTimeBegin;
            ViewBag.txtTimeEnd = txtTimeEnd;
            ViewBag.txtSanPham = txtSanPham;
            ViewBag.txtCaSanXuat = txtCaSanXuat;
            ViewBag.txtDayChuyen = txtDayChuyen;
            ViewBag.txtMaySo = txtMaySo;

            if (txtTimeBegin == "All" || txtTimeEnd == "All")
                temp1 = "NgaySanXuat = ANY(SELECT NgaySanXuat FROM[Report])";
            else temp1 = "convert(date, NgaySanXuat) between '" + txtTimeBegin + "' and '" + txtTimeEnd + "'";
            if (txtSanPham == "All") temp2 = "ANY(SELECT SanPham FROM[Report])"; else temp2 = txtSanPham;
            if (txtCaSanXuat == "All") temp3 = "ANY(SELECT CaSanXuat FROM[Report])"; else temp3 = txtCaSanXuat;
            if (txtDayChuyen == "All") temp4 = "ANY(SELECT DayChuyen FROM[Report])"; else temp4 = txtDayChuyen;
            if (txtMaySo == "All") temp5 = "ANY(SELECT MaySo FROM[Report])"; else temp5 = txtMaySo;

            string query = "SELECT * FROM[dbo].[Report] where " +
                temp1 + " AND " +
                "SanPham = " + temp2 + " AND " +
                "CaSanXuat = " + temp3 + " AND " +
                "DayChuyen = " + temp4 + " AND " +
                "MaySo = " + temp5;

            var temp = DataProvider.Ins.DB.Reports.SqlQuery(query);
            return View(temp);
        }
        #endregion
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class MultipleButtonAttribute : ActionNameSelectorAttribute
    {
        public string Name { get; set; }
        public string Argument { get; set; }

        public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
        {
            var isValidName = false;
            var keyValue = string.Format("{0}:{1}", Name, Argument);
            var value = controllerContext.Controller.ValueProvider.GetValue(keyValue);

            if (value != null)
            {
                controllerContext.Controller.ControllerContext.RouteData.Values[Name] = Argument;
                isValidName = true;
            }

            return isValidName;
        }
    }
}