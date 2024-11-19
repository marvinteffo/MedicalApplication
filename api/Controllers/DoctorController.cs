using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Dtos.Doctor;
using api.Models;
using api.Data;
using api.Mappers;

namespace api.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public DoctorController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor([FromBody] DoctorCreateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

           /* var newDoctor = new Doctor
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Specialty = dto.Specialty,
                Email = dto.Email
            };*/
            var newDoctor = DoctorMapper.MapToDoctor(dto);

            _context.Doctors.Add(newDoctor);
            await _context.SaveChangesAsync();

           // return Ok(newDoctor);
           return Ok(DoctorMapper.MapToDoctorResponseDto(newDoctor));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await _context.Doctors.ToListAsync();
            var doctorsDtos = doctors.Select(d => DoctorMapper.MapToDoctorResponseDto(d)).ToList();

            return Ok(doctorsDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctorById(int id)
              {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
                return NotFound("Doctor not found!");

            // Return the response DTO
            return Ok(DoctorMapper.MapToDoctorResponseDto(doctor));
        }
          [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctor(int id, [FromBody] DoctorUpdateDto dto)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
                return NotFound("Doctor not found!");

            // Update Doctor with the DTO data
            DoctorMapper.UpdateDoctorFromDto(dto, doctor);
            
            _context.Doctors.Update(doctor);
            await _context.SaveChangesAsync();

            return NoContent();
        }
           [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
                return NotFound();

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}