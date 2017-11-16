﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildrenCalendar.Models
{
    public class Age
    {
        private int[] years = { 0, 1, 2, 3, 4, 5, 6, 7 };
        private int[] months = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        public int[] Years { get { return years; } }
        public int[] Months { get { return months; } }
    }
}