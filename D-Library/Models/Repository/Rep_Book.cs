﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.IO;
using D_Library.Models.Domins;
using D_Library.Models.Model;
using D_Library.Models.Repository;
using D_Library.Models.UserManagement;
using D_Library.Models.Plugins;
using Newtonsoft.Json;
using System.Data.Entity;

namespace D_Library.Models.Repository
{
    public class Rep_Book
    {
        ELEntities db = new ELEntities();

        public Rep_Book()
        {

        }

        public List<DropDownModel> Get_BookTypeCreate()
        {
            List<DropDownModel> list = new List<DropDownModel>();
            foreach (var item in db.Tbl_BookType)
            {
                list.Add(new DropDownModel(item.BookType_ID ,item.BookType_Name));
            }

            return list;
        }

        public IEnumerable<SelectListItem> Get_BookCategorySelectList()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var item in db.Tbl_BookCategory)
            {
                list.Add(new SelectListItem() { Value = item.BC_ID.ToString(), Text = item.BC_Name });
            }

            return list.AsEnumerable();
        }

        public List<string> Get_BookDetailsListByBookType(int id)
        {
            List<string> list = new List<string>();

            var q = db.Tbl_BookDetailsNavigator.Where(a => a.Tbl_BookType.BookType_ID == id);
            SortedDictionary<int, string> order = new SortedDictionary<int, string>();


            foreach (var item in q)
            {
                order.Add(item.Tbl_BookDetailsFeatures.BDF_Priority, item.Tbl_BookDetailsFeatures.BDF_Name);
            }

            list.AddRange(order.Values.ToList());

            return list;
        }

        public List<DropDownModel> Get_BookDetailsListAll()
        {

            List<DropDownModel> list = new List<DropDownModel>();
            foreach (var item in db.Tbl_BookDetailsFeatures)
            {
                list.Add(new DropDownModel(item.BDF_ID, item.BDF_Titel));
            }

            return list;
        }

        public IEnumerable<SelectListItem> Get_BookDetailsAllSelectList()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var item in db.Tbl_BookDetailsFeatures)
            {
                list.Add(new SelectListItem() { Value = item.BDF_ID.ToString(), Text = item.BDF_Titel });
            }

            return list.AsEnumerable();
        }

        public List<DropDownModel> Get_BookDetailsListByType(int? TypeId)
        {

            return null;
        }

        public string Get_BookTypeNameByID(int id)
        {
            string name = db.Tbl_BookType.Where(a => a.BookType_ID == id).SingleOrDefault().BookType_Name;

            return name;
        }

        public List<string> Get_TagsByBookID(int id)
        {
            var list = db.Tbl_Book.Where(a => a.Book_ID == id).SingleOrDefault().Tbl_BookTag.ToList();
            List<string> tags = new List<string>();
            foreach (var item in list)
            {
                tags.Add(item.Tbl_Tag.Tag_Name);
            }

            return tags;
        }

        public IQueryable<Tbl_Book> Get_UserAccessBookList()
        {

            IQueryable<Tbl_Book> Books;


            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string ip = HttpContext.Current.Request.UserHostAddress;

                Books = db.Tbl_Book.Where(a => a.Tbl_BookAcsses.BookAcsses_Guest == true);

            }
            else
            {
                 Books = db.Tbl_Book.Where(a => a.Tbl_BookAcsses.BookAcsses_Guest == true && a.Book_Publish);
            }

   


            return Books;
        }


    }
}