using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2_23TH.Models;

namespace BaiTap2_23TH.Controllers
{
    public class SinhVien_23THController : Controller
    {
        // GET: SinhVien_23TH
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register2(FormCollection field)
        {
            ViewBag.Id = field["Id"];
            ViewBag.Name = field["Name"];
            ViewBag.Marks = field["Marks"];
            return View(ViewBag);
        }
        
        // Cách 2
        [HttpPost]
        public ActionResult Register3()
        {
            ViewBag.Id = Request["Id"];
            ViewBag.Name = Request["Name"];
            ViewBag.Marks = Request["Marks"];
            return View(ViewBag);
        }
        
        // Cách 3
        [HttpPost]
        public ActionResult Register4(string Id, string Name, string Marks)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Marks = Marks;
            return View(ViewBag);
        }
        
        // Cách 4
        [HttpPost]
        public ActionResult UseModel1(SVModel sV)
        {
            ViewBag.Id = sV.Id;
            ViewBag.Name = sV.Name;
            ViewBag.Marks = sV.Marks;
            return View(ViewBag);
        }
    }
}