using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     [Table("DoctorSchedules")]
    public class DoctorSchedule
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public bool IsAvailable { get; set; } // true if available for appointments, false otherwise
    }
}