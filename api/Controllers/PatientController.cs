using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Dtos.Patient;
using api.Models;
using api.Data;
using Microsoft.VisualBasic;
using api.Mappers;


namespace api.Controllers
{
    [Route("api/patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public PatientController(ApplicationDBContext context)
        {
            _context = context;
        }
         

        [HttpPost]
        public async Task<IActionResult> CreatePatient([FromBody] PatientCreateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newPatient = PatientMapper.MapToPatient(dto);

            _context.Patients.Add(newPatient);
            await _context.SaveChangesAsync();

            return Ok(PatientMapper.MapToPatientResponseDto(newPatient));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound("Patient not found!");

            return Ok(PatientMapper.MapToPatientResponseDto(patient));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _context.Patients.ToListAsync();
            var patientDtos = patients.Select(p=> PatientMapper.MapToPatientResponseDto(p)).ToList();
            return Ok(patientDtos);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(int id, [FromBody] PatientUpdateDto dto)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound("Patient not found!");

           /* patient.FirstName = dto.FirstName ?? patient.FirstName;
            patient.LastName = dto.LastName ?? patient.LastName;
            patient.Email = dto.Email ?? patient.Email;
            */
            PatientMapper.UpdatePatientFromDto(dto, patient);
            
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}