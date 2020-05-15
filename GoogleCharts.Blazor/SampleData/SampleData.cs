using GoogleCharts.Blazor.Lib;
using GoogleCharts.Blazor.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleCharts.Blazor
{
    public class SampleData
    {
        public List<Hierarchy> hierarchyData
        {
            get
            {
                return new List<Hierarchy> {
                     new Hierarchy {  MemberId= 1, Name= "Nancy Davolio", ParentId = 4 },
                     new Hierarchy {  MemberId= 2, Name= "Andrew Fuller", ParentId = 4 },
                     new Hierarchy {  MemberId= 3, Name= "Janet Leverling", ParentId = 4 },
                     new Hierarchy {  MemberId= 4, Name= "Margaret Peacock", ParentId = null },
                     new Hierarchy {  MemberId= 5, Name= "Steven Buchanan", ParentId = 3 },
                     new Hierarchy {  MemberId= 6, Name= "Michael Suyama", ParentId =  3 },
                     new Hierarchy {  MemberId= 7, Name= "Robert King", ParentId = 2 },
                     new Hierarchy {  MemberId= 8, Name= "Laura Callahan", ParentId = 2 },
                     new Hierarchy {  MemberId= 9, Name= "Anne Dodsworth", ParentId = 2 }
                };
            }
        }

        public List<LineSampleData> lineChartData
        {
            get
            {
                return new List<LineSampleData>
                {
                    new LineSampleData { Date = 1, Income = 1000, Tax = 200, Cost = 500 },
                    new LineSampleData { Date = 2, Income = 1200, Tax = 300, Cost = 600 },
                    new LineSampleData { Date = 3, Income = 1300, Tax = 340, Cost = 0 },
                    new LineSampleData { Date = 4, Income = 1200, Tax = 280, Cost = 300 },
                    new LineSampleData { Date = 5, Income = 1500, Tax = 450, Cost = 250 },
                };
            }
        }


    }

    public class LineSampleData
    {
        public double Date { get; set; }
        public double Income { get; set; }
        public double Tax { get; set; }
        public double Cost { get; set; }
    }
}
