using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;
using ASF.UI.WbSite.Services.Cache;



namespace ASF.UI.WbSite.Controllers
{
    public class CategoryController : Controller
    // get category

    {

        public ActionResult Index()
        {
            // var cp= new CategoryProcess();
            var lista = DataCache.Instance.CategoryList();
            return View(lista);



        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                var cp = new CategoryProcess();
                cp.InsertCategory(category);
                DataCache.Instance.CategoryListRemove();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var cp = new CategoryProcess();

            return View(cp.findCategory(id));
        }

        public ActionResult Edit(int id)
        {
            var cp = new CategoryProcess();

            return View(cp.findCategory(id));
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                var cp = new CategoryProcess();
                cp.EditCategory(category);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var cp = new CategoryProcess();

            return View(cp.findCategory(id));
        }
        [HttpPost]



        public ActionResult Delete(int id, Category category)
        {
            try
            {
                var cp = new CategoryProcess();
                cp.DeleteCategory(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




    }
}


