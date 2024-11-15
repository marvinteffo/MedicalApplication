using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     [Table("Patients")]
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public string LastName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string EmergencyContact { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public string MedicalHistory { get; set; } = string.Empty;
        public DateTime DateRegistered { get; set; } = DateTime.Now; 
    }
}