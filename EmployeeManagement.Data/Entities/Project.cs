using System;
using System.Collections.Generic;

namespace EmployeeManagement.Data.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime Deadline { get; set; }

      
        public ICollection<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}