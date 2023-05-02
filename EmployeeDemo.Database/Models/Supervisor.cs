using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeDemo.Database.Models;

public class Supervisor
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string MiddleName { get; set; }
	public DateTime DateOfBirth { get; set; }

	public virtual ICollection<Employee> Employees { get; set; }
}
