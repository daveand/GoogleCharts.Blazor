using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleCharts.Blazor.Lib.Models
{
    public class OrgChartConfiguration
    {
        public string Id { get; set; }
        public List<Hierarchy> Data { get; set; }

    }
}
