using Microsoft.AspNet.Mvc;
using ASPNET_Core_Diagnostics.Models;
using ASPNET_Core_Diagnostics.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNET_Core_Diagnostics.Controllers
{
    public class EmployeeController : Controller
    {
        IService<Employee> _service;
        public EmployeeController(IService<Employee> srv)
        {
            _service = srv;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var Emps = _service.Get();
            return View(Emps);
        }
    }
}
