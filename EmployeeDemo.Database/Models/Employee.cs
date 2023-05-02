using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDemo.Database.Models;

public class Employee
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string MiddleName { get; set; }
	public DateTime DateOfBirth { get; set; }

	public int? SupervisorId { get; set; }
	[ForeignKey("SupervisorId")]
	public virtual Supervisor Supervisor { get; set; }
}