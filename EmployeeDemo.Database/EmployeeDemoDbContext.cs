using EmployeeDemo.Database.Models;
using Microsoft.EntityFrameworkCore;


namespace EmployeeDemo.Database;

public class EmployeeDemoDbContext : DbContext
{
	public EmployeeDemoDbContext(DbContextOptions<EmployeeDemoDbContext> options) : base(options)
	{
		
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
		optionsBuilder.UseSqlServer("Data Source=localhost;Database=EmployeeDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		new DbInitializer(modelBuilder).Seed();
	}

	public DbSet<Employee> Employees { get; set; }
	public DbSet<Supervisor> Supervisors { get; set; }
}
