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
    public class PrecioController : ControllerBase
    {
        private readonly DataContext _context;

        public PrecioController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Precio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Precio>>> Getprecios()
        {
            return await _context.precios.ToListAsync();
        }

        // GET: api/Precio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Precio>> GetPrecio(DateTime id)
        {
            var precio = await _context.precios.FindAsync(id);

            if (precio == null)
            {
                return NotFound();
            }

            return precio;
        }

        // PUT: api/Precio/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrecio(DateTime id, Precio precio)
        {
            if (id != precio.fechahora)
            {
                return BadRequest();
            }

            _context.Entry(precio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrecioExists(id))
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

        // POST: api/Precio
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Precio>> PostPrecio(Precio precio)
        {
            _context.precios.Add(precio);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PrecioExists(precio.fechahora))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPrecio", new { id = precio.fechahora }, precio);
        }

        // DELETE: api/Precio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Precio>> DeletePrecio(DateTime id)
        {
            var precio = await _context.precios.FindAsync(id);
            if (precio == null)
            {
                return NotFound();
            }

            _context.precios.Remove(precio);
            await _context.SaveChangesAsync();

            return precio;
        }

        private bool PrecioExists(DateTime id)
        {
            return _context.precios.Any(e => e.fechahora == id);
        }
    }
}
