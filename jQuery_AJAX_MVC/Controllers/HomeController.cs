using jQuery_AJAX_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery_AJAX_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            PersonModel person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString()
            };
            return Json(person);
        }

        //Demo 1------------
        [HttpPost]
        public JsonResult AjaxMethodModel(PersonModel person)
        {
            
            return Json(person);
        }

        //Demo 2
        public ActionResult Item()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxItem(Item person)
        {

            return Json(person);
        }


        //Demo 3
        [HttpPost]
        public JsonResult AjaxListItem(List<Item> personList)
        {

            return Json(personList);
        }


    }
}