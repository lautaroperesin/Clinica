﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaBackend.DataContext;
using ClinicaServices.Models;

namespace ClinicaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        private readonly ClinicaContext _context;

        public TurnosController(ClinicaContext context)
        {
            _context = context;
        }

        // GET: api/Turnos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turno>>> GetTurnos()
        {
            return await _context.Turnos
                              .Include(t => t.Paciente)
                               .ThenInclude(p => p.Mutual)
                              .Include(t => t.MedicoEfector)
                              .Include(t => t.Practica)
                              .ToListAsync();
        }

        [HttpGet("turnosAtendidos")]
        public async Task<ActionResult<IEnumerable<Turno>>> GetTurnosAtendidos()
        {
            return await _context.Turnos
                .Where(t => t.Atendido)
                .Include(t => t.Paciente)
                    .ThenInclude(p => p.Mutual)
                .Include(t => t.MedicoEfector)
                .Include(t => t.Practica)
                .ToListAsync();
        }

        [HttpGet("{medicoId}/{fecha}")]
        public async Task<IActionResult> GetTurnosFiltrados(int medicoId, DateTime fecha)
        {
            if (medicoId <= 0)
                return BadRequest("El ID del médico no es válido.");

            try
            {
                var turnos = await _context.Turnos.Where(c => c.MedicoEfectorId == medicoId && c.FechaTurno.Value.Date == fecha.Date)
                              .OrderBy(t => t.FechaTurno)
                              .Include(t => t.Paciente)
                               .ThenInclude(p => p.Mutual)
                              .Include(t => t.MedicoEfector)
                              .Include(t => t.Practica)
                              .ToListAsync();
                return Ok(turnos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        // GET: api/Turnos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Turno>> GetTurno(int id)
        {
            var turno = await _context.Turnos.FindAsync(id);

            if (turno == null)
            {
                return NotFound();
            }

            return turno;
        }

        // PUT: api/Turnos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurno(int id, Turno turno)
        {
            if (id != turno.Id)
            {
                return BadRequest();
            }

            _context.Entry(turno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurnoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Turnos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Turno>> PostTurno(Turno turno)
        {
            _context.Turnos.Add(turno);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTurno", new { id = turno.Id }, turno);
        }

        // DELETE: api/Turnos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurno(int id)
        {
            var turno = await _context.Turnos.FindAsync(id);
            if (turno == null)
            {
                return NotFound();
            }

            turno.Eliminado = true;
            _context.Turnos.Update(turno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TurnoExists(int id)
        {
            return _context.Turnos.Any(e => e.Id == id);
        }
    }
}
