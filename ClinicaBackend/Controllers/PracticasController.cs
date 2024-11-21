using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaBackend.DataContext;
using ClinicaServices.Models;
using ClinicaServices.Enums;

namespace ClinicaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracticasController : ControllerBase
    {
        private readonly ClinicaContext _context;

        public PracticasController(ClinicaContext context)
        {
            _context = context;
        }

        // GET: api/Practicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Practica>>> GetPracticas()
        {
            return await _context.Practicas.ToListAsync();
        }

        [HttpGet("practicas/{tecnica}")]
        public async Task<IActionResult> GetPracticasPorTecnica(TecnicaEnum tecnica)
        {
            try
            {
                var practicas = await _context.Practicas
                             .Where(p => p.Tecnica == tecnica)
                             .ToListAsync();

                if (practicas == null || !practicas.Any())
                    return NotFound("No se encontraron prácticas para la técnica seleccionada.");

                return Ok(practicas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        // GET: api/Practicas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Practica>> GetPractica(int id)
        {
            var practica = await _context.Practicas.FindAsync(id);

            if (practica == null)
            {
                return NotFound();
            }

            return practica;
        }

        // PUT: api/Practicas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPractica(int id, Practica practica)
        {
            if (id != practica.Id)
            {
                return BadRequest();
            }

            _context.Entry(practica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PracticaExists(id))
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

        // POST: api/Practicas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Practica>> PostPractica(Practica practica)
        {
            _context.Practicas.Add(practica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPractica", new { id = practica.Id }, practica);
        }

        // DELETE: api/Practicas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePractica(int id)
        {
            var practica = await _context.Practicas.FindAsync(id);
            if (practica == null)
            {
                return NotFound();
            }

            practica.Eliminado = true;
            _context.Practicas.Update(practica);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PracticaExists(int id)
        {
            return _context.Practicas.Any(e => e.Id == id);
        }
    }
}
