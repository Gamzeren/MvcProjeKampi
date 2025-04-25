using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

       // [Authorize(Roles ="B")] //Sadece B rolüne sahip kişiler bu sayfayı görüntüleyebilsin.
        public ActionResult Index()
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
            CategoryValidator categoryvalidator=new CategoryValidator();
            ValidationResult result=categoryvalidator.Validate(p);
            if (result.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalues = cm.GetByID(id);
            cm.CategoryDelete(categoryvalues);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult editCategory(int id)
        {
            var categoryvalue=cm.GetByID(id);
            return View(categoryvalue);
        }
        [HttpPost]
        public ActionResult editCategory(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
            
        }
    }
}