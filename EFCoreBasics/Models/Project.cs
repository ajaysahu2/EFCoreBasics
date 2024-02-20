﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    public class Project
    {
        public int ProjectId { get; set; } //Primary Key
        public string Name { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; } //Collection navigation property

    }
}
