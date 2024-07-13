using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutor_X_Tution_Management.Data;
using Tutor_X_Tution_Management.Data.Enum;
using Tutor_X_Tution_Management.Model;

namespace Tutor_X_Tution_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorPostsController : ControllerBase
    {
        private readonly apiDbContext _context;

        public TutorPostsController(apiDbContext context)
        {
            _context = context;
        }

#nullable enable
        // GET: api/TutorPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorPost>>> Gettutor_post([FromQuery] string? location,
          [FromQuery] StudentMedium? studentMedium, [FromQuery] SubjectTypes? subjectTypes, [FromQuery] StudentTypes? studentTypes)
        {
            var query=_context.tutor_post.AsQueryable();

            if (location != null)
            {
                query = query.Where(p => p.location == location);
            }


            if (studentMedium != null)
            {
                query = query.Where(p => p.studentMedium == studentMedium);
            }

            if (subjectTypes != null)
            {
                query = query.Where(p => p.subjectOfInterest == subjectTypes);
            }

            if (studentTypes != null)
            {
                query = query.Where(p => p.expectedStudent == studentTypes);
            }

            return await query.ToListAsync();
        }

        // GET: api/TutorPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorPost>> GetTutorPost(int id)
        {
            var tutorPost = await _context.tutor_post.FindAsync(id);

            if (tutorPost == null)
            {
                return NotFound();
            }

            return tutorPost;
        }

        // PUT: api/TutorPosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorPost(int id, TutorPost tutorPost)
        {
            if (id != tutorPost.tutorPostId)
            {
                return BadRequest();
            }

            _context.Entry(tutorPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorPostExists(id))
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

        // POST: api/TutorPosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TutorPost>> PostTutorPost(TutorPost tutorPost)
        {
            _context.tutor_post.Add(tutorPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTutorPost", new { id = tutorPost.tutorPostId }, tutorPost);
        }

        // DELETE: api/TutorPosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTutorPost(int id)
        {
            var tutorPost = await _context.tutor_post.FindAsync(id);
            if (tutorPost == null)
            {
                return NotFound();
            }

            _context.tutor_post.Remove(tutorPost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TutorPostExists(int id)
        {
            return _context.tutor_post.Any(e => e.tutorPostId == id);
        }
    }
}
