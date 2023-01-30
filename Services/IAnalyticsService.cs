using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPatternDemo.Services
{
    public interface IAnalyticsService
    {
        void GenerateReport(string json);
    }
}
