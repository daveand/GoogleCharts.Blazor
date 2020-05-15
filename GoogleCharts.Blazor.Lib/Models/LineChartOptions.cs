using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleCharts.Blazor.Lib.Models
{
    public class LineChartOptions
    {
        private HAxis hAxis;
        private VAxis vAxis;

        public HAxis HAxis 
        {
            get 
            {
                if (hAxis == null)
                {
                    hAxis = new HAxis();
                }
                return hAxis;
            }
        }

        public VAxis VAxis
        {
            get
            {
                if (vAxis == null)
                {
                    vAxis = new VAxis();
                }
                return vAxis;
            }
        }
    }

    public class HAxis
    {
        public string Title { get; set; }
    }

    public class VAxis
    {
        public string Title { get; set; }
    }

}
