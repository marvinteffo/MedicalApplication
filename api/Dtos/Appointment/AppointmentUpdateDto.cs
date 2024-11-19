using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Appointment
{
    public class AppointmentUpdateDto
    {
        public DateTime? AppointmentDate { get; set; }
        public string? Notes { get; set; }
        public string Status { get; set; }
    }
}