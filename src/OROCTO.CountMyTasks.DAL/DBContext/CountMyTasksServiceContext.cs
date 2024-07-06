namespace OROCTO.CountMyTasks.DAL.DBContext;
using Microsoft.EntityFrameworkCore;

public class CountMyTasksServiceContext : DbContext
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public CountMyTasksServiceContext(DbContextOptions<CountMyTasksServiceContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Program>().HasKey("");
    }
    
    //public DbSet<>
}