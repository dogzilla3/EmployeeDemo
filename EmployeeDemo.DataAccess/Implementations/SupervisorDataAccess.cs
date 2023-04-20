using EmployeeDemo.DataAccess.Interfaces;
using EmployeeDemo.Database;
using EmployeeDemo.Database.Models;
using System.Collections.Generic;
using System.Linq;


namespace EmployeeDemo.DataAccess.Implementations;

public class SupervisorDataAccess : ISupervisorDataAccess
{
	public EmployeeDemoDbContext dbContext { get; set; }

	public SupervisorDataAccess(EmployeeDemoDbContext context)
	{
		dbContext = context;
	}

	public List<Supervisor> GetAll()
	{
		return dbContext.Supervisors.ToList();
	}

	public void Create(Supervisor supervisor)
	{
		dbContext.Supervisors.Add(supervisor);
		dbContext.SaveChanges();
	}
}
