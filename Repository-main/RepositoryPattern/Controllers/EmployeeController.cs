using CRUD.MODEL.MODEL;
using CRUD.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService=null;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public ActionResult Index()
        {
            var data=employeeService.GetAllEmployee();
            return View(data);

        }
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeService.Create(employee);
                return RedirectToAction("Index");
            }
            return View();
            

        }
        public ActionResult Edit(int id)
        {
            Session["id"] =id;
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid) 
            { 
            employeeService.Edit(employee);
            return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var data=employeeService.GetEmployeeById(id);
            employeeService.Delete(data);
            return View("Index");
        }

    }
}
