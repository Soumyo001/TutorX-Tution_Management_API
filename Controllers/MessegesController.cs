using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutor_X_Tution_Management.Data;
using Tutor_X_Tution_Management.Model;

namespace Tutor_X_Tution_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessegesController : ControllerBase
    {
        private readonly apiDbContext _context;

        public MessegesController(apiDbContext context)
        {
            _context = context;
        }

        // GET: api/Messeges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Messege>>> Getmessege()
        {
            return await _context.messege.ToListAsync();
        }

        // GET: api/Messeges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Messege>> GetMessege(string id)
        {
            var messege = await _context.messege.FindAsync(id);

            if (messege == null)
            {
                return NotFound();
            }

            return messege;
        }

        // PUT: api/Messeges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessege(string id, Messege messege)
        {
            if (id != messege.messegeId)
            {
                return BadRequest();
            }

            _context.Entry(messege).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessegeExists(id))
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

        // POST: api/Messeges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Messege>> PostMessege(Messege messege)
        {
            _context.messege.Add(messege);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MessegeExists(messege.messegeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMessege", new { id = messege.messegeId }, messege);
        }

        // DELETE: api/Messeges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessege(string id)
        {
            var messege = await _context.messege.FindAsync(id);
            if (messege == null)
            {
                return NotFound();
            }

            _context.messege.Remove(messege);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessegeExists(string id)
        {
            return _context.messege.Any(e => e.messegeId == id);
        }
    }
}
