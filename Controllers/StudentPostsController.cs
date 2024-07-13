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
    public class StudentPostsController : ControllerBase
    {
        private readonly apiDbContext _context;

        public StudentPostsController(apiDbContext context)
        {
            _context = context;
        }
#nullable enable
        // GET: api/StudentPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentPost>>> Getstudent_post([FromQuery] string? location,
          [FromQuery] StudentMedium? studentMedium, [FromQuery] StudentTypes? studentTypes, [FromQuery] SubjectTypes? subjectTypes)
        {
            var query = _context.student_post.AsQueryable();

            if(location!=null)
            {
                query = query.Where(p => p.location == location);
            }

            if (studentMedium != null)
            {
                query = query.Where(p => p.studentMedium == studentMedium); 
            }

            if (studentTypes != null)
            {
                query = query.Where(p => p.studentTypes == studentTypes);
            }

            if (subjectTypes != null)
            {
                query = query.Where(p => p.subjectTypes == subjectTypes);
            }       

            return await query.ToListAsync();
        }

        // GET: api/StudentPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentPost>> GetStudentPost(int id)
        {
            var studentPost = await _context.student_post.FindAsync(id);

            if (studentPost == null)
            {
                return NotFound();
            }

            return studentPost;
        }

        // PUT: api/StudentPosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentPost(int id, StudentPost studentPost)
        {
            if (id != studentPost.studentPostId)
            {
                return BadRequest();
            }

            _context.Entry(studentPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentPostExists(id))
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

        // POST: api/StudentPosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentPost>> PostStudentPost(StudentPost studentPost)
        {
            _context.student_post.Add(studentPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentPost", new { id = studentPost.studentPostId }, studentPost);
        }

        // DELETE: api/StudentPosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentPost(int id)
        {
            var studentPost = await _context.student_post.FindAsync(id);
            if (studentPost == null)
            {
                return NotFound();
            }

            _context.student_post.Remove(studentPost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentPostExists(int id)
        {
            return _context.student_post.Any(e => e.studentPostId == id);
        }
    }
}
