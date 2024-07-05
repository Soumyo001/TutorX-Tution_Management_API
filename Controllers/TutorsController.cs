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
    public class TutorsController : ControllerBase
    {
        private readonly apiDbContext _context;

        public TutorsController(apiDbContext context)
        {
            _context = context;
        }

        // GET: api/Tutors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tutor>>> Gettutor([FromQuery] int? userId)
        {
            var query = _context.tutor.AsQueryable();
            if (userId.HasValue)
            {
                query = query.Where(p => p.userId == userId.Value);
            }
            return await query.ToListAsync();
        }

        // GET: api/Tutors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tutor>> GetTutor(int id)
        {
            var tutor = await _context.tutor.FindAsync(id);

            if (tutor == null)
            {
                return NotFound();
            }

            return tutor;
        }

        // PUT: api/Tutors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutor(int id, Tutor tutor)
        {
            if (id != tutor.tutorId)
            {
                return BadRequest();
            }

            _context.Entry(tutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorExists(id))
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

        // POST: api/Tutors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tutor>> PostTutor(Tutor tutor)
        {
            _context.tutor.Add(tutor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTutor", new { id = tutor.tutorId }, tutor);
        }

        // DELETE: api/Tutors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTutor(int id)
        {
            var tutor = await _context.tutor.FindAsync(id);
            if (tutor == null)
            {
                return NotFound();
            }

            _context.tutor.Remove(tutor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TutorExists(int id)
        {
            return _context.tutor.Any(e => e.tutorId == id);
        }
    }
}
