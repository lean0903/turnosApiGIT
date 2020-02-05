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
    public class JornadasController : ControllerBase
    {
        private readonly DataContext _context;

        public JornadasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Jornadas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jornada>>> Getjornadas()
        {
            return await _context.jornadas.ToListAsync();
        }

        // GET: api/Jornadas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jornada>> GetJornada(int id)
        {
            var jornada = await _context.jornadas.FindAsync(id);

            if (jornada == null)
            {
                return NotFound();
            }

            return jornada;
        }

        // PUT: api/Jornadas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJornada(int id, Jornada jornada)
        {
            if (id != jornada.id)
            {
                return BadRequest();
            }

            _context.Entry(jornada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JornadaExists(id))
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

        // POST: api/Jornadas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Jornada>> PostJornada(Jornada jornada)
        {
            _context.jornadas.Add(jornada);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJornada", new { id = jornada.id }, jornada);
        }

        // DELETE: api/Jornadas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Jornada>> DeleteJornada(int id)
        {
            var jornada = await _context.jornadas.FindAsync(id);
            if (jornada == null)
            {
                return NotFound();
            }

            _context.jornadas.Remove(jornada);
            await _context.SaveChangesAsync();

            return jornada;
        }

        private bool JornadaExists(int id)
        {
            return _context.jornadas.Any(e => e.id == id);
        }
    }
}
