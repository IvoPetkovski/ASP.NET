using Homework02.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework02.Models
{
    public class EmployeeDetails
    {
        public string FullEmployeeName { get; set; }

        public Position Position { get; set; }

        public string DateOfHire { get; set; }

        public string DivisionName { get; set; }
    }
}
