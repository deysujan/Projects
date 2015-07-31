﻿using System.Web.Mvc;
using Demo_project.Models;


namespace Demo_project.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult GetCustomer()
        {
            return new JsonResult
            {
                Data = new Customer{Name = "Sujan Dey",Address = "Stavangergatn 52"},
                ContentType = "application/json",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

    }
}
