using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseMVCNoEntity.BLL.BussinessLogic;
using BaseMVCNoEntity.Model;

namespace BaseMVCNoEntity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ListUser()
        {
            HomeBLL Home = new HomeBLL();
            HomeModel Model = new HomeModel()
            {
                ListUser = Home.GetDataUser(),
            };
            return PartialView("_ListUser", Model);
        }

        [HttpPost]
        public string InsertUser(UserModel Model)
        {
            HomeBLL Home = new HomeBLL();
            string Result = Home.InsertOrUpdateUser(Model);
            return Result;
        }

        [HttpPost]
        public string DeleteUser(UserModel Model)
        {
            HomeBLL Home = new HomeBLL();
            string Result = Home.DeleteUser(Model);
            return Result;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}