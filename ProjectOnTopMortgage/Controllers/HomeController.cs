using ProjectOnTopMortgage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnTopMortgage.Controllers
{
    public class HomeController : Controller
    {
        private TopMortgageEntities _db = new TopMortgageEntities();
        // GET: Home


        [HttpGet]
        public ActionResult Index()
        {
            CustDetail model = new CustDetail();
            return View(model);
        }

        [HttpPost]
        public ActionResult CustInfo(CustDetail model)
        {
            _db.CustDetails.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index","ThankYou");
        }
        [HttpPost]
        public ActionResult CallBackSummary(RequestaCallBack model)
        {
            _db.RequestaCallBacks.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index","CallSummary");
        
        }
    }
}