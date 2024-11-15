using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     [Table("Appointments")]
    public class Appointment
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }

        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public string Status { get; set; }  = string.Empty;// e.g., Scheduled, Completed, Cancelled
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}