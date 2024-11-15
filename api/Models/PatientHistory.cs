using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
        [Table("PatientsHistory")]
    public class PatientHistory
      {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }

        public string MedicalCondition { get; set; } = string.Empty;
        public DateTime DateDiagnosed { get; set; } = DateTime.Now;
        public string Treatment { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}