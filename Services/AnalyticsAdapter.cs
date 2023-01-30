using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdapterDesignPatternDemo.Models;

namespace AdapterDesignPatternDemo.Services
{
    //public class AnalyticsAdapter : IAnalyticsAdapter
    //{
    //    private readonly IAnalyticsService _analyticsService;

    //    public AnalyticsAdapter(IAnalyticsService analyticsService)
    //    {
    //        _analyticsService = analyticsService;
    //    }

    //    public void ProcessEmployees(List<Employee> employees)
    //    {
    //        var json = System.Text.Json.JsonSerializer.Serialize(employees);

    //        _analyticsService.GenerateReport(json);
    //    }
    //}

    public class AnalyticsAdapter : AnalyticsService, IAnalyticsAdapter
    {
        public void ProcessEmployees(List<Employee> employees)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(employees);

            GenerateReport(json);
        }
    }
}
