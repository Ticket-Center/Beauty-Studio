using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyStudio.Models
{
    internal class Users
    {
        public int id { get; set; }
        public string username { get; set; } = null!;
        public string first_name { get; set; } = null!;
        public string last_name { get; set; } = null!;
        public string email { get; set; } = null!;
        public string password { get; set; } = null!;
        public bool is_active { get; set;}
        public Roles role { get; set; }

        public ICollection<Appointments> appointments { get; set; } = null!;
    }
}
