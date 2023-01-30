using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPatternDemo.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        public void GenerateReport(string json)
        {
            // Process json to generate report.
        }
    }
}
