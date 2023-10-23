using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WannaTrade.Models;
using Newtonsoft.Json;

namespace WannaTrade.Controllers
{
    public class HomeController : Controller
    {
        MsSqlConnector db = new MsSqlConnector();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult Chat()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Registration()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Requests_Sales()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Requests_Buys()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Stats()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Search()
        {
            

            return View();
        }
        public JsonResult CheckPas(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<User>(sendData);
                var data = db.User_Check(sendData1);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult UserReg(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<User>(sendData);
                var data = db.User_Reg(sendData1);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult LoadItems(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<Items_load_Result>(sendData);
                var data = db.Items_load(sendData1);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult LoadItemsSales(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<Items_load_Result>(sendData);
                var data = db.Items_load_Sales(sendData1);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult LoadItemsBuys(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<Items_load_Result>(sendData);
                var data = db.Items_load_Buys(sendData1);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult LoadItemsSalesGen(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<Items_load_Result>(sendData);
                var data = db.Items_load_Sales_Gen(sendData1);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult SaleInsert(string sendData, string user)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<Items_load_Result>(sendData);
                var dat = db.Sale_Ins(sendData1,user);
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult SaleAdd(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<HelperClass.SaleAdd>(sendData);
                var dat = db.Sale_Add(sendData1);
                if (dat.ToArray()[0]==0)
                    return Json("error1", JsonRequestBehavior.AllowGet);
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult SaleDelete(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<HelperClass.SaleDel>(sendData);
                var dat = db.Sale_Delete(sendData1);
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult LoadTier()
        {
            try
            {
                var data = db.Tier_Load();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult LoadGroup()
        {
            try
            {
                var data = db.Group_Load();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult LoadCategory(int val)
        {
            try
            {
                var data = db.Category_Load(val);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public void ConfirmBuy(int request_id, int cass)
        {
            try
            {
                var data = db.Confirm_Buy(request_id, cass);
            }
            catch (Exception ex)
            {
                var lol = 1;
            }
        }
        public JsonResult StatsGet(string sendData)
        {
            try
            {
                var sendData1 = JsonConvert.DeserializeObject<HelperClass.StatsHelp>(sendData);
                var dat = db.Stats_Get(sendData1);
                return Json(dat, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
    }
}