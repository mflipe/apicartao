using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCartoes.Models;

namespace apicartao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartoesController : ControllerBase
    {
        private readonly CartoesContext _context;

        public CartoesController(CartoesContext context)
        {
            _context = context;
        }

        // GET: api/Cartoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cartao>>> GetCartao()
        {
            return await _context.Cartoes.ToListAsync();
        }

        // GET: api/Cartoes/{email}
        [HttpGet("{email}")]
        public async Task<ActionResult<IEnumerable<Cartao>>> GetCartaos(string email)
        {
            var cartoes = await _context.Cartoes
                .Where(b => b.Email == email)
                .OrderBy(b => b.Id)
                .ToListAsync();

            if (cartoes == null)
            {
                return NotFound();
            }

            return cartoes;
        }


        // PUT: api/Cartoes/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartao(long id, Cartao cartao)
        {
            if (id != cartao.Id)
            {
                return BadRequest();
            }

            _context.Entry(cartao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartaoExists(id))
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

        // POST: api/Cartoes
        [HttpPost]
        public async Task<ActionResult<Cartao>> PostCartao(Cartao cartao)
        {
            cartao.Numero = RandomString(16);
            _context.Cartoes.Add(cartao);
            await _context.SaveChangesAsync();

            //CreatedAtAction(nameof(GetCartao), new { id = cartao.Id }, new { cartao.Numero });
            return CreatedAtAction(nameof(GetCartao), new { id = cartao.Email }, new { cartao.Numero });
        }

        // DELETE: api/Cartoes/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartao(long id)
        {
            var cartao = await _context.Cartoes.FindAsync(id);
            if (cartao == null)
            {
                return NotFound();
            }

            _context.Cartoes.Remove(cartao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CartaoExists(long id)
        {
            return _context.Cartoes.Any(e => e.Id == id);
        }
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}