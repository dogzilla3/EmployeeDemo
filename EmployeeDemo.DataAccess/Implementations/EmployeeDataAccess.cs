using EmployeeDemo.DataAccess.Interfaces;
using EmployeeDemo.Database;
using EmployeeDemo.Database.Models;
using System.Collections.Generic;
using System.Linq;


namespace EmployeeDemo.DataAccess.Implementations;

public class EmployeeDataAccess : IEmployeeDataAccess
{
    public EmployeeDemoDbContext dbContext { get; set; }

    public EmployeeDataAccess(EmployeeDemoDbContext context)
    {
        dbContext = context;
    }

    public List<Employee> GetAll()
    {
        return dbContext.Employees.ToList();
    }

	public void Create(Employee employee)
	{
		dbContext.Employees.Add(employee);
        dbContext.SaveChanges();
	}
}
