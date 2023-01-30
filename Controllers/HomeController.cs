using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using AdapterDesignPatternDemo.Models;
using AdapterDesignPatternDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdapterDesignPatternDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeesService;
        private readonly IAnalyticsAdapter _analyticsAdapter;
       // private readonly IAnalyticsService _analyticsService;

        public HomeController(IEmployeeService employeesService
            , IAnalyticsAdapter analyticsAdapter
            //, IAnalyticsService analyticsService
            )
        {
            _employeesService = employeesService;
            _analyticsAdapter = analyticsAdapter;

            //_analyticsService = analyticsService;
        }

        public IActionResult Index()
        {
            var employees = _employeesService.GetEmployees();
            return View(employees);
        }

        [HttpPost]
        public IActionResult SubmitEmployees()
        {
            var employees = _employeesService.GetEmployees();

            //_analyticsService.GenerateReport(employees);

            _analyticsAdapter.ProcessEmployees(employees);

            return RedirectToAction("Index");
        }
    }
}
