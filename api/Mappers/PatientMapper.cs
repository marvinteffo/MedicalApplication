using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Patient;
using api.Models;

namespace api.Mappers
{
    public static class PatientMapper
    {
        public static Patient MapToPatient(PatientCreateDto dto){
            return new Patient{
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                DateOfBirth = dto.DateOfBirth,
                Gender = dto.Gender,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                Address = dto.Address,
                DateRegistered = dto.DateRegistered,
                EmergencyContact =  dto.EmergencyContact,
                MedicalHistory = dto.MedicalHistory,
            };
        }

        public static PatientResponseDto MapToPatientResponseDto(Patient patient){
            return new PatientResponseDto{
                Id = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
               DateOfBirth = patient.DateOfBirth,
               Gender = patient.Gender,
               Address = patient.Address,
               Email = patient.Email,
               DateRegistered = patient.DateRegistered,
               EmergencyContact = patient.EmergencyContact,
               MedicalHistory = patient.MedicalHistory,
               PhoneNumber = patient.PhoneNumber 
            };
        }

        public static void UpdatePatientFromDto(PatientUpdateDto dto, Patient patient){
            if(!string.IsNullOrWhiteSpace(dto.FirstName)) patient.FirstName = dto.FirstName;
            if(!string.IsNullOrWhiteSpace(dto.PhoneNumber)) patient.PhoneNumber = dto.PhoneNumber;
            if(!string.IsNullOrWhiteSpace(dto.LastName)) patient.LastName = dto.LastName;
            if(!string.IsNullOrWhiteSpace(dto.Email)) patient.Email = dto.Email;
            if(!string.IsNullOrWhiteSpace(dto.Address)) patient.Address = dto.Address;
        }
    }
}