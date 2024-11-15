using System;
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
    public class MutualesController : ControllerBase
    {
        private readonly ClinicaContext _context;

        public MutualesController(ClinicaContext context)
        {
            _context = context;
        }

        // GET: api/Mutuales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mutual>>> GetMutuales()
        {
            return await _context.Mutuales.ToListAsync();
        }

        // GET: api/Mutuales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mutual>> GetMutual(int id)
        {
            var mutual = await _context.Mutuales.FindAsync(id);

            if (mutual == null)
            {
                return NotFound();
            }

            return mutual;
        }

        // PUT: api/Mutuales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMutual(int id, Mutual mutual)
        {
            if (id != mutual.Id)
            {
                return BadRequest();
            }

            _context.Entry(mutual).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MutualExists(id))
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

        // POST: api/Mutuales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mutual>> PostMutual(Mutual mutual)
        {
            _context.Mutuales.Add(mutual);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMutual", new { id = mutual.Id }, mutual);
        }

        // DELETE: api/Mutuales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMutual(int id)
        {
            var mutual = await _context.Mutuales.FindAsync(id);
            if (mutual == null)
            {
                return NotFound();
            }

            mutual.Eliminado = true;
            _context.Mutuales.Update(mutual);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MutualExists(int id)
        {
            return _context.Mutuales.Any(e => e.Id == id);
        }
    }
}
