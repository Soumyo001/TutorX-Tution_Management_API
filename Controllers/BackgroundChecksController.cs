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
    public class BackgroundChecksController : ControllerBase
    {
        private readonly apiDbContext _context;

        public BackgroundChecksController(apiDbContext context)
        {
            _context = context;
        }

        // GET: api/BackgroundChecks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BackgroundChecks>>> Getbackground_checks()
        {
            return await _context.background_checks.ToListAsync();
        }

        // GET: api/BackgroundChecks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BackgroundChecks>> GetBackgroundChecks(int id)
        {
            var backgroundChecks = await _context.background_checks.FindAsync(id);

            if (backgroundChecks == null)
            {
                return NotFound();
            }

            return backgroundChecks;
        }

        // PUT: api/BackgroundChecks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBackgroundChecks(int id, BackgroundChecks backgroundChecks)
        {
            if (id != backgroundChecks.checkId)
            {
                return BadRequest();
            }

            _context.Entry(backgroundChecks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BackgroundChecksExists(id))
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

        // POST: api/BackgroundChecks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BackgroundChecks>> PostBackgroundChecks(BackgroundChecks backgroundChecks)
        {
            _context.background_checks.Add(backgroundChecks);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBackgroundChecks", new { id = backgroundChecks.checkId }, backgroundChecks);
        }

        // DELETE: api/BackgroundChecks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBackgroundChecks(int id)
        {
            var backgroundChecks = await _context.background_checks.FindAsync(id);
            if (backgroundChecks == null)
            {
                return NotFound();
            }

            _context.background_checks.Remove(backgroundChecks);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BackgroundChecksExists(int id)
        {
            return _context.background_checks.Any(e => e.checkId == id);
        }
    }
}
