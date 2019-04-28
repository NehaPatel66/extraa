using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using extraa.Models;
using Newtonsoft.Json;


namespace extraa.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/Index
        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult CustomerList()
        {
            OnboardingTalentTaskEntities db = new OnboardingTalentTaskEntities();
            var customerList = db.Customers.Select(x => new CustomerModel
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address
            }).ToList();
            return Json(customerList, JsonRequestBehavior.AllowGet);
            //return new JsonResult { Data = customerList, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
       

       
         //Create:
        public JsonResult CreateCustomer(Customer c)
        {

            OnboardingTalentTaskEntities db = new OnboardingTalentTaskEntities();
            db.Customers.Add(c);
            db.SaveChanges();

            return new JsonResult { Data = "Success", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

       
    }
}
