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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => 
            {
                entity.Property(e => e.type)
                .HasConversion<string>();
            });

            modelBuilder.Entity<Tutor>(entity => 
            {
                entity.Property(e => e.status)
                .HasConversion<string>();
                
                entity.Property(e => e.mediumOfInterest)
                .HasConversion<string>();

                entity.Property(e => e.expectedStudent)
                .HasConversion<string>();

                entity.Property(e => e.subjectOfInterest)
                .HasConversion<string>();

                entity.Property(e => e.profession)
                .HasConversion<string>();

                entity.Property(e => e.verificationStatus)
                .HasConversion<string>();

            }) ;

            modelBuilder.Entity<Student>(entity => 
             {
                 entity.Property(e=>e.StudentMedium)
                 .HasConversion<string>();

              
             });

            modelBuilder.Entity<Session>(entity=>
            {
                entity.Property(e=>e.sessionStatus)
                .HasConversion<string>();

             
            });

            modelBuilder.Entity<Payment>(entity => 
            {
                entity.Property(e=>e.paymentMethod)
                .HasConversion<string>();

                entity.Property(e=>e.paymentStatus)
                .HasConversion<string>();
            });

            modelBuilder.Entity<Request>(entity => 
            {
                entity.Property(e=>e.status)
                .HasConversion<string>();
            });

            modelBuilder.Entity<BackgroundChecks>(entity => 
            {
                entity.Property(e=>e.backgroundCheckedType)
                .HasConversion<string>(); 
                entity.Property(e=>e.result)
                .HasConversion<string>();
            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
