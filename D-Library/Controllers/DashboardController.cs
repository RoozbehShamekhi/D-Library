﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using D_Library.Models.Domins;
using D_Library.Models.Model;

namespace D_Library.Controllers
{
    public class DashboardController : Controller
    {
        ELEntities db = new ELEntities();
        // GET: Dashboard

       
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Models.UserManagement.CustomAuthorize]
        public ActionResult Dashboard()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");


            }
            return View();
        }
        #region users

     
        [HttpGet]
        public ActionResult BuildRegisterCode()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");


            }
            return View();
        }
        [HttpPost]
        public ActionResult BuildRegisterCode( RegisterCodeModel model, int SelectRole)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");

            }
            if (!ModelState.IsValid)
            {
                ViewBag.State = "Error";

                return View("BuildRegisterCode", model);
            }

            var q = db.Tbl_Login.Where(a => a.Login_UserName == model.Username).SingleOrDefault();
            int Code;
            if (q != null )
            {
                if (!q.Login_RegisterActive)
                {
                    ViewBag.Message = "عملبات با موفقیت انجام نشده!";
                    ViewBag.State = "Error";
                    return View();
                }
                else
                {
                    if (q.Tbl_RegisterCode.RegisterCode_Date.AddDays(-5) < DateTime.Now)
                    {
                        ViewBag.Message = "عملبات با موفقیت انجام شده!";
                        ViewBag.Code = q.Tbl_RegisterCode.RegisterCode_Code;
                        ViewBag.Username = model.Username;
                        ViewBag.State = "Sucsse";
                        return View();
                    }
                    else
                    {
                        Random rnd = new Random();

                        Code = rnd.Next(100000, 999999);

                        q.Tbl_RegisterCode.RegisterCode_Code = Code.ToString();
                        q.Tbl_RegisterCode.RegisterCode_Date = DateTime.Now;
                        q.Login_BaseRoleID = SelectRole;

                        db.Entry(q.Tbl_RegisterCode).State = System.Data.Entity.EntityState.Modified;



                    }
                }
            }
            else
            {
                Tbl_Login L = new Tbl_Login();
                L.Login_UserName = model.Username;
                L.Login_RegisterActive = true;
                L.Login_BaseRoleID = SelectRole;
                L.Login_CustomRole = false;
                L.Login_UserActive = true;
               

                Tbl_RegisterCode r = new Tbl_RegisterCode();
                Random rnd = new Random();

                Code = rnd.Next(100000, 999999);

                r.RegisterCode_Code = Code.ToString();
                r.RegisterCode_Date = DateTime.Now;
              

                L.Tbl_RegisterCode = r;

                db.Tbl_RegisterCode.Add(r);
                db.Tbl_Login.Add(L);
            }



            if (Convert.ToBoolean(db.SaveChanges() > 0))
            {


                ViewBag.Message = "عملبات با موفقیت انجام شده!";
                ViewBag.Code = Code;
                ViewBag.Username = model.Username;
                ViewBag.State = "Sucsse";
                return View();



            }
            else
            {
                ViewBag.Message = "عملبات با موفقیت انجام نشده!";
                ViewBag.State = "Error";
                return View();
            }



        }

        #endregion
        [HttpGet]
        public ActionResult RequestTypeSelector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RequestTypeSelector(int x)
        {
            return View();
        }

        [HttpGet]
        public ActionResult RequestUploadFile()
        {
            return View();
        }
    }

}