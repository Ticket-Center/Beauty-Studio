using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyStudio.Models
{
    internal class Appointments
    {
        public int id { get; set; }
        public DateTime appointmentDate { get; set; }
        public HourOfDay appointmentHour { get; set; }
        public Status status { get; set; }

        public Employee employee { get; set; } = null!;
        public ServiceTypes serviceTypes { get; set; } = null!;

    }
}
