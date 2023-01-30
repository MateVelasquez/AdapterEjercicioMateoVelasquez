using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdapterDesignPatternDemo.Models;

namespace AdapterDesignPatternDemo.Services
{
    public interface IAnalyticsAdapter
    {
        void ProcessEmployees(List<Employee> employees);
    }
}
