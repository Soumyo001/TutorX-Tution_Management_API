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
                entity.HasMany(c => c.resources)
                .WithOne(pc => pc.user);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasOne(c => c.user)
                .WithMany(pc => pc.resources);
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

                entity.HasOne(c => c.backgroundChecks)
                .WithOne(pc => pc.tutor);

                entity.HasMany(c => c.sessions)
                .WithOne(pc => pc.tutor);

                entity.HasMany(c => c.requests)
                .WithOne(pc => pc.tutor);

                entity.HasMany(c => c.reports)
                .WithOne(pc => pc.tutor);

                entity.HasMany(c => c.messeges)
                .WithOne(pc => pc.tutor);
            }) ;

            modelBuilder.Entity<Student>(entity => 
             {
                 entity.Property(e=>e.StudentMedium)
                 .HasConversion<string>();

                 entity.HasMany(c => c.requests)
                 .WithOne(pc => pc.student);

                 entity.HasMany(c => c.reports)
                 .WithOne(pc => pc.student);

                 entity.HasMany(c => c.messeges)
                 .WithOne(pc => pc.student);

                 entity.HasOne(c => c.session)
                 .WithOne(pc => pc.student);

                 entity.HasMany(c => c.studentReviews)
                 .WithOne(pc => pc.student);
             });

            modelBuilder.Entity<Session>(entity=>
            {
                entity.Property(e=>e.sessionStatus)
                .HasConversion<string>();

                entity.HasOne(c => c.student)
                .WithOne(pc => pc.session);

                entity.HasOne(c=>c.tutor)
                .WithMany(pc => pc.sessions);

                entity.HasOne(c => c.payment)
                .WithOne(pc => pc.session);
            });

            modelBuilder.Entity<Payment>(entity => 
            {
                entity.Property(e=>e.paymentMethod)
                .HasConversion<string>();

                entity.Property(e=>e.paymentStatus)
                .HasConversion<string>();

                entity.HasOne(c => c.session)
                .WithOne(pc => pc.payment);
            });

            modelBuilder.Entity<Request>(entity => 
            {
                entity.Property(e=>e.status)
                .HasConversion<string>();
                entity.HasOne(c => c.student)
                .WithMany(pc => pc.requests);
                entity.HasOne(c => c.tutor)
                .WithMany(pc => pc.requests);
            });

            modelBuilder.Entity<Report>(entity => 
            {
                entity.HasOne(c => c.student)
                .WithMany(pc => pc.reports);
                entity.HasOne(c => c.tutor)
                .WithMany(pc => pc.reports);
            });

            modelBuilder.Entity<Messege>(entity => 
            {
                entity.HasOne(c => c.student)
                .WithMany(pc => pc.messeges);

                entity.HasOne(c => c.tutor)
                .WithMany(pc => pc.messeges);
            });

            modelBuilder.Entity<StudentReview>(entity => 
            {
                entity.HasOne(c => c.student)
                .WithMany(pc => pc.studentReviews);
            });

            modelBuilder.Entity<BackgroundChecks>(entity => 
            {
                entity.Property(e=>e.backgroundCheckedType)
                .HasConversion<string>(); 
                entity.Property(e=>e.result)
                .HasConversion<string>();

                entity.HasOne(c => c.tutor)
                .WithOne(pc => pc.backgroundChecks);
            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
