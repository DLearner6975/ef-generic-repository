using Core.Data.Entities;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ef_generic_repository.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        private readonly IEmployeeService _employeeService;

        #endregion

        #region Constructors
        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }

        #endregion

        #region Utilities



        #endregion
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await _employeeService.GetAllEmployees());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeService.Insert(employee);
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception)
                {
                    //Log Exception code
                }
            }

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id = 0)
        {
            if (id == 0)
                return HttpNotFound();

            Employee employee = await _employeeService.GetEmployeeById(id);

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Employee employee, int id = 0)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Employee eNew = await _employeeService.GetEmployeeById(id);

                    eNew.FirstName = employee.FirstName;
                    eNew.LastName = employee.LastName;
                    eNew.Address = employee.Address;
                    eNew.Age = employee.Age;
                    eNew.Designation = employee.Designation;
                    eNew.Salary = employee.Salary;

                    await _employeeService.Update(eNew);
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception)
                { 
                    //Log Exception Code
                }
            }

            return View(employee);
        }


        [HttpGet]
        public async Task<ActionResult> Details(int id = 0)
        {
            if (id == 0)
                return HttpNotFound();

            Employee employee = await _employeeService.GetEmployeeById(id);

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id = 0)
        {
            if (id == 0)
                return HttpNotFound();

            Employee employee = await _employeeService.GetEmployeeById(id);

           await _employeeService.Delete(employee);

            return RedirectToAction("Index","Home");
        }

    }
}