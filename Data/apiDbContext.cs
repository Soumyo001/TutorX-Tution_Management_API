using Microsoft.EntityFrameworkCore;
using Tutor_X_Tution_Management.Model;

namespace Tutor_X_Tution_Management.Data
{
    public class apiDbContext:DbContext
    {
        public apiDbContext(DbContextOptions<apiDbContext> options) : base(options) 
        {
            
        }
        public DbSet<User> user { get; set; }
        public DbSet<Tutor> tutor { get; set; }
        public DbSet<Student> student { get; set; }
        public DbSet<StudentReview> student_review { get; set; }
        public DbSet<Session> session { get; set; }
        public DbSet<Resource> resource { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<Messege> messege { get; set; }
        public DbSet<Report> report { get; set; }
        public DbSet<Request> request { get; set; }
        public DbSet<BackgroundChecks> background_checks { get; set; }


    }
}
