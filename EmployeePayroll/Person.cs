﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll_Service_ADO_database
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
