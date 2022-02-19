using SCADAMasan.Models;
using SCADAMasan.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCADAMasan.Areas.SCADAGroup.Controllers
{
    public class ForTestController : Controller
    {
        // GET: SCADAGroup/ForTest
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult createAccount(Account std)
        {
            DataProvider.Ins.DB.Accounts.Add(std);
            DataProvider.Ins.DB.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        public JsonResult getAccount(string id)
        {
            List<Account> temp = new List<Account>();
            temp = DataProvider.Ins.DB.Accounts.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TestAjax1()
        {
            return View();
        }
    }
}