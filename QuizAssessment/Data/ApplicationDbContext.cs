using Microsoft.EntityFrameworkCore;
using QuizAssessment.Models;

namespace QuizAssessment.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option): base(option)
        {
            
        }
        public DbSet<Quiz> Quizzes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quiz>().HasData(
                new Quiz { Id=1, Question="What is 1+1?", Answer="2"},
                new Quiz { Id=2, Question="What is 1+2?", Answer="3"}
                );
        }
        public DbSet<Assessment> Assessments { get; set; }
    }
}
