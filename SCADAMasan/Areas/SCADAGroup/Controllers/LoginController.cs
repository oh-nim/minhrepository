using SCADAMasan.Areas.SCADAGroup.Models;
using SCADAMasan.Models;
using SCADAMasan.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCADAMasan.Areas.SCADAGroup.Controllers
{
    public class LoginController : Controller
    {
        // GET: SCADAGroup/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel loginmodel)
        {
            if (ModelState.IsValid)
            {
                var result = Login(loginmodel.username, loginmodel.password);
                if (result != null)
                {
                    loginmodel.username = result.Username;
                    loginmodel.fullname = result.DisplayName;
                    Session.Add(Constants.USER_SESSION, loginmodel);
                    return RedirectToAction("Index", "Main");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại");
                }
            }
            else
            {
                ModelState.AddModelError("", "Đăng nhập thất bại");
            }
            return View("Index");
        }

        public ActionResult Logout()
        {
            Session[Constants.USER_SESSION] = null;
            return RedirectToAction("Index", "Login");

        }

        public Account Login(string user, string pass)
        {
            var result = DataProvider.Ins.DB.Accounts.SingleOrDefault(x => x.Username.Contains(user) && x.Pass.Contains(pass));
            return result;
        }

        public List<Account> ListAccount()
        {
            return DataProvider.Ins.DB.Accounts.ToList();
        }

        public string Insert(Account ent_User)
        {
            DataProvider.Ins.DB.Accounts.Add(ent_User);
            DataProvider.Ins.DB.SaveChanges();
            return ent_User.Username;
        }

        public void Delete(Account ent_User)
        {
            DataProvider.Ins.DB.Accounts.Remove(ent_User);
            DataProvider.Ins.DB.SaveChanges();
        }      

        public Account Find(string username)
        {
            return DataProvider.Ins.DB.Accounts.Find(username);
        }
    }
}