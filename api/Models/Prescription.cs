using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Prescriptions")]
    public class Prescription
    {
         public int Id { get; set; }
        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }

        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public string Medication { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public DateTime DateIssued { get; set; } = DateTime.Now;
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}