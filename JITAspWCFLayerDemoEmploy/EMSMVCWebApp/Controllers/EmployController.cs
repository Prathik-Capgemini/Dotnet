using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS.BLL;
using EMS.DAL.EmployServiceReference;

namespace EMSMVCWebApp.Controllers
{
    public class EmployController : Controller
    {
        // GET: Employ
        public ActionResult Index()
        {
            List<Employ> eList = EmployBLL.GetEmploysBLL();
            return View(eList);
        }

        // GET: Employ/Details/5
        public ActionResult Details(int id)
        {
            Employ employ = EmployBLL.GetEmployBLL(id);
            return View(employ);
        }

        // GET: Employ/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employ/Create
        [HttpPost]

        public ActionResult Create(Employ employ)
        {
            bool status = EmployBLL.AddEmployBLL(employ);
            if (status)
            {
                return RedirectToAction("Index", "Employ");
            }
            return View();
        }
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Employ/Edit/5
        public ActionResult Edit(int id)
        {
            Employ employ = EmployBLL.GetEmployBLL(id);
            return View(employ);
        }

        // POST: Employ/Edit/5
        [HttpPost]

        public ActionResult Edit(Employ employ)
        {
            bool status = EmployBLL.UpdateEmployBLL(employ);
            if (status)
            {
                return RedirectToAction("Index", "Employ");
            }
            return View();
        }

        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Employ/Delete/5
        public ActionResult Delete(int id)
        {
            Employ employ = EmployBLL.GetEmployBLL(id);
            return View(employ);
        }

        // POST: Employ/Delete/5
        [HttpPost]

        public ActionResult Delete(Employ employ)
        {
            int id = Convert.ToInt32(employ.Empno);
            string status = EmployBLL.DeleteEmployBLL(id);
            if (status.Equals("Record not Found.."))
            {
                return RedirectToAction("Index", "Employ");
            }
            return View();
        }
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
