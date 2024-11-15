using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     [Table("Doctors")]
    public class Doctor
     {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public string LastName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public string Specialty { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]

        public string Email { get; set; } = string.Empty;
        public string OfficeLocation { get; set; } = string.Empty;
        public DateTime DateHired { get; set; } = DateTime.Now;
        public DateTime LastAvailable { get; set; } = DateTime.Now; // Could be used for scheduling
    }
}