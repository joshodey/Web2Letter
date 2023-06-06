using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Letter> letters { get; set; }
        public DbSet<SupportingDocument> supportindDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Letter>()
                .HasMany<SupportingDocument>();
            builder.Entity<SupportingDocument>().HasOne(x =>
            x.LetterId);
        }
    }
}
