using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLab456.Models
{
    public class Attendance
    {
        public Course Course { get; set; }

        [key]
        [Column(OrderedParallelQuery = 1]

    }
}