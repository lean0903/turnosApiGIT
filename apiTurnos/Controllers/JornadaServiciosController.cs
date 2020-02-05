using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiTurnos.Data;
using apiTurnos.Models;

namespace apiTurnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JornadaServiciosController : ControllerBase
    {
        private readonly DataContext _context;

        public JornadaServiciosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/JornadaServicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JornadaServicio>>> GetjornadasServicios()
        {
            return await _context.jornadasServicios.ToListAsync();
        }

        // GET: api/JornadaServicios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JornadaServicio>> GetJornadaServicio(int id)
        {
            var jornadaServicio = await _context.jornadasServicios.FindAsync(id);

            if (jornadaServicio == null)
            {
                return NotFound();
            }

            return jornadaServicio;
        }

        // PUT: api/JornadaServicios/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJornadaServicio(int id, JornadaServicio jornadaServicio)
        {
            if (id != jornadaServicio.jornadaId)
            {
                return BadRequest();
            }

            _context.Entry(jornadaServicio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JornadaServicioExists(id))
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

        // POST: api/JornadaServicios
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<JornadaServicio>> PostJornadaServicio(JornadaServicio jornadaServicio)
        {
            _context.jornadasServicios.Add(jornadaServicio);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JornadaServicioExists(jornadaServicio.jornadaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJornadaServicio", new { id = jornadaServicio.jornadaId }, jornadaServicio);
        }

        // DELETE: api/JornadaServicios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JornadaServicio>> DeleteJornadaServicio(int id)
        {
            var jornadaServicio = await _context.jornadasServicios.FindAsync(id);
            if (jornadaServicio == null)
            {
                return NotFound();
            }

            _context.jornadasServicios.Remove(jornadaServicio);
            await _context.SaveChangesAsync();

            return jornadaServicio;
        }

        private bool JornadaServicioExists(int id)
        {
            return _context.jornadasServicios.Any(e => e.jornadaId == id);
        }
    }
}
