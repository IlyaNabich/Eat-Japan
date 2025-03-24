using Microsoft.EntityFrameworkCore;
namespace Eat_Japan.DataAccess
{
    public class AppContext(DbContextOptions<AppContext> options) : DbContext(options)
    {
        public DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasKey(x => x.Id);
            modelBuilder.Entity<Note>().Property(x => x.Id).HasMaxLength(140);
            base.OnModelCreating(modelBuilder);
        }
    }
}
