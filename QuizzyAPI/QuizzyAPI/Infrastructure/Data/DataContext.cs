using Microsoft.EntityFrameworkCore;
using QuizzyAPI.Domain;
using System.Reflection;


namespace QuizzyAPI.Infrastructure.Data
{
    public class DataContext : DbContext
    {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlite("Filename=QuizzyDB.db");
    //    base.OnConfiguring(optionsBuilder);
    //}

    //public DbSet<Value> Values { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Category> Categories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserRole>()
            .HasKey(bc => new { bc.UserId, bc.RoleId });

        modelBuilder.Entity<Question>()
           .HasOne(c=>c.Category).WithMany().HasForeignKey(c=>c.CategoryId);

        modelBuilder.Entity<Question>().HasMany(c => c.Answers).WithOne().OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Category>().HasMany(c => c.Questions).WithOne().OnDelete(DeleteBehavior.SetNull);
    }
}

}
