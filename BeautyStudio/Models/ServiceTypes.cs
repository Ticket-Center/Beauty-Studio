using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyStudio.Models
{
    internal class ServiceTypes
    {
        public int id { get; set; }
        public string service { get; set; } = null!;
        public int duration { get; set; }

    }
}
