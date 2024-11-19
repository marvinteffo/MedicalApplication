using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Appointment
{
    public class AppointmentCreateDto
      {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Notes { get; set; }
        public string Status { get; set; } // e.g., Scheduled, Completed
    }
}