using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Appointment;
using api.Models;
using Microsoft.AspNetCore.Mvc;



namespace api.Mappers
{
    public static class AppointmentMapper
    {
        public static Appointment MapToAppointment(AppointmentCreateDto dto){
            
                return new Appointment{
                    PatientId = dto.PatientId,
                    DoctorId = dto.DoctorId,
                    AppointmentDate = dto.AppointmentDate,
                    Notes = dto.Notes
                };
            }

        public static AppointmentResponseDto MapToAppointmentResponseDto(AppointmentCreateDto appointment){
            return new AppointmentResponseDto{
                Id = appointment.Id,
                PatientId = appointment.PatientId,
                AppointmentDate = appointment.AppointmentDate,
                DoctorId = appointment.DoctorId,
                Notes = appointment.Notes

            };
        }
          public static void UpdateAppointmentFromDto(AppointmentUpdateDto dto, Appointment appointment){
            if(dto.AppointmentDate.HasValue){
                appointment.AppointmentDate = dto.AppointmentDate.Value;
            }
            if(!string.IsNullOrWhiteSpace(dto.Notes)){
                appointment.Notes = dto.Notes;
            }
        }
    }
}