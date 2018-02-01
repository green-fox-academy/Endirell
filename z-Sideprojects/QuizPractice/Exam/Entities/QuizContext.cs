using Microsoft.EntityFrameworkCore;
using Quiz.Models;

namespace Quiz.Entities
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
    }
}
