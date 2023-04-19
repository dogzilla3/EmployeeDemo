using EmployeeDemo.Database.Models;
using EmployeeDemo.Database;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDemo.DataAccess.Interfaces;

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
}
