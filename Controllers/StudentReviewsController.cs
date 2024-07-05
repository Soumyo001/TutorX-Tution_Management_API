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
    public class StudentReviewsController : ControllerBase
    {
        private readonly apiDbContext _context;

        public StudentReviewsController(apiDbContext context)
        {
            _context = context;
        }

        // GET: api/StudentReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentReview>>> Getstudent_review([FromQuery] int? studentId, [FromQuery] int? tutorId)
        {
            var query = _context.student_review.AsQueryable();
            if (studentId.HasValue)
            {
                query = query.Where(p => p.studentId == studentId.Value);
            }
            if (tutorId.HasValue)
            {
                query = query.Where(p => p.tutorId == tutorId.Value);
            }
            return await query.ToListAsync();
        }

        // GET: api/StudentReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentReview>> GetStudentReview(int id)
        {
            var studentReview = await _context.student_review.FindAsync(id);

            if (studentReview == null)
            {
                return NotFound();
            }

            return studentReview;
        }

        // PUT: api/StudentReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentReview(int id, StudentReview studentReview)
        {
            if (id != studentReview.studentReviewId)
            {
                return BadRequest();
            }

            _context.Entry(studentReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentReviewExists(id))
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

        // POST: api/StudentReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentReview>> PostStudentReview(StudentReview studentReview)
        {
            _context.student_review.Add(studentReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentReview", new { id = studentReview.studentReviewId }, studentReview);
        }

        // DELETE: api/StudentReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentReview(int id)
        {
            var studentReview = await _context.student_review.FindAsync(id);
            if (studentReview == null)
            {
                return NotFound();
            }

            _context.student_review.Remove(studentReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentReviewExists(int id)
        {
            return _context.student_review.Any(e => e.studentReviewId == id);
        }
    }
}
