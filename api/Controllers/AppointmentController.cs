using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Dtos.Appointment;
using api.Models;
using api.Data;
using api.Mappers;

namespace api.Controllers
{
    [Route("api/appointment")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
                private readonly ApplicationDBContext _context;

        public AppointmentController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpPost]
public async Task<IActionResult> CreateAppointment([FromBody] AppointmentCreateDto dto)
{
    if (!ModelState.IsValid) return BadRequest(ModelState);

   
        var appointment = AppointmentMapper.MapToAppointment(dto);
        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();

        return Ok(AppointmentMapper.MapToAppointmentResponseDto(appointment));
  
    
}


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointmentById(int id)
        {
            var appointment = await _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (appointment == null) return NotFound("Appointment not found!");

            return Ok(appointment);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAppointments()
        {
            var appointments = await _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .ToListAsync();

            return Ok(appointments);
        }
    }
}