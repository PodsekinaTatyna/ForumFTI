using ForumFTI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ForumFTI.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Theme> Themes { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected readonly IConfiguration Configuration;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

    }
}
