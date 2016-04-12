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
        public async Task<ActionResult> Index()
        {
            return View(await _employeeService.GetAllEmployees());
        }
	}
}