using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Doctor
{
    public class DoctorResponseDto
    {
           public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string OfficeLocation { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime LastAvailable { get; set; }
    }
}