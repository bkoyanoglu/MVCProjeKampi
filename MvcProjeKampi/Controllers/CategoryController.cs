<<<<<<< HEAD
﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
=======
﻿using System;
>>>>>>> daedb645274e641e6cf8e79cc7f264a71941f664
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
<<<<<<< HEAD
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
=======
>>>>>>> daedb645274e641e6cf8e79cc7f264a71941f664
        public ActionResult Index()
        {
            return View();
        }
<<<<<<< HEAD
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
                {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
                }
            else
                {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                }
            return View();
        }
    }


=======
    }
>>>>>>> daedb645274e641e6cf8e79cc7f264a71941f664
}