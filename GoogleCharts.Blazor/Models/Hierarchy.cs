﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleCharts.Blazor
{
    public class Hierarchy
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }

}
