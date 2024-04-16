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
    }
}
