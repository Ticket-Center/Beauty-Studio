using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyStudio.Models
{
    internal class EmployeeTypes
    {
        public int id {  get; set; }
        public string type { get; set; } = null!;
    }
}
