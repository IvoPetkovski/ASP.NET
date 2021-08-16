using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework02.Models
{
    public class Division
    {
        public int DivisionId { get; set; }

        public string Name { get; set; }

        public Employee HeadOfDivision { get; set; }

        public Division(int divisionId, string name, Employee headOfDivision)
        {
            DivisionId = divisionId;
            Name = name;
            HeadOfDivision = headOfDivision;
        }
    }
}
