﻿using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class ContentController : BaseController
    {
        // GET: Admin/Content
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }



        public void SetViewBag(long? selectedId = null)
        {
            var dao = new CategoryDao();
            ViewBag.CategoryID = new SelectList(dao.AllList(), "ID", "Name", selectedId);
        }
    }
}