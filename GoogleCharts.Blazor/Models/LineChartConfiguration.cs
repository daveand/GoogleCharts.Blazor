using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GoogleCharts.Blazor
{
    public class LineChartConfiguration
    {
        public string Id { get; set; }
        public IEnumerable<object[]> Columns { get; set; }
        public IEnumerable<object[]> Data { get; set; }
        public object Options { get; set; }

    }
}
