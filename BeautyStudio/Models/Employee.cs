using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyStudio.Models
{
    internal class Employee
    {
        public int id { get; set; }
        public string first_name { get; set; } = null!;
        public string last_name { get; set; } = null!;
        public string email { get; set; } = null!;
        public EmployeeTypes types { get; set; } = null!;
    }
}
