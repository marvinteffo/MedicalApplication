using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Doctor;
using api.Models;

namespace api.Mappers
{
    public static class DoctorMapper
    {
        public static Doctor MapToDoctor(DoctorCreateDto dto){
            return new Doctor{
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Specialty = dto.Specialty,
                DateHired = dto.DateHired
            };
        }

        public static DoctorResponseDto MapToDoctorResponseDto(Doctor doctor){
            return new DoctorResponseDto{
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Specialty = doctor.Specialty,
                Email = doctor.Email
            };
        }
        public static void UpdateDoctorFromDto(DoctorUpdateDto dto, Doctor doctor){
            if (!string.IsNullOrWhiteSpace(dto.FirstName)) doctor.FirstName = dto.FirstName;
            if (!string.IsNullOrWhiteSpace(dto.LastName)) doctor.LastName = dto.LastName;
            if (!string.IsNullOrWhiteSpace(dto.Email)) doctor.Email = dto.Email;
            if (!string.IsNullOrWhiteSpace(dto.PhoneNumber)) doctor.PhoneNumber = dto.PhoneNumber;
            if (!string.IsNullOrWhiteSpace(dto.Specialty)) doctor.Specialty = dto.Specialty;
            if (!string.IsNullOrWhiteSpace(dto.OfficeLocation)) doctor.OfficeLocation = dto.OfficeLocation;

        }
    }
}