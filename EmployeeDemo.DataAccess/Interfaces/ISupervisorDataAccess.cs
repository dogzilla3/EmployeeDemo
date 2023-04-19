using EmployeeDemo.Database.Models;
using EmployeeDemo.Database;
using System.Collections.Generic;


namespace EmployeeDemo.DataAccess.Interfaces
{
	public interface ISupervisorDataAccess
	{
		EmployeeDemoDbContext dbContext { get; set; }

		List<Supervisor> GetAll();
	}
}
