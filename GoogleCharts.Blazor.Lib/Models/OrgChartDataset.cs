using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleCharts.Blazor.Lib.Models
{
    public class OrgChartDataset
    {
        public List<Object> Data { get; set; }

        public OrgChartDataset(List<Object> data)
        {
            Data = data;
        }
    }
}
