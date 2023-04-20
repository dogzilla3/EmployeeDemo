using EmployeeDemo.Database.Models;
using System.Collections.Generic;


namespace EmployeeDemo.DataAccess.Interfaces;

public interface ISupervisorDataAccess
{
	public List<Supervisor> GetAll();
	public void Create(Supervisor supervisor);
}
