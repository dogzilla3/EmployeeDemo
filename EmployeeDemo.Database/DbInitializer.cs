using EmployeeDemo.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Media;

namespace EmployeeDemo.Database;

public class DbInitializer
{
	private readonly ModelBuilder modelBuilder;

	public DbInitializer(ModelBuilder modelBuilder)
	{
		this.modelBuilder = modelBuilder;
	}

	public void Seed()
	{
		SeedEmployees();
		SeedSupervisors();
	}

	private void SeedSupervisors()
	{
		modelBuilder.Entity<Supervisor>().HasData(
			new Supervisor
			{
				Id = 1,
				FirstName = "Jameson",
				MiddleName = "Bear",
				LastName = "Bruce",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Supervisor
			{
				Id = 2,
				FirstName = "Sammie",
				MiddleName = "Catherin",
				LastName = "Kaylee",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Supervisor
			{
				Id = 3,
				  
				FirstName = "Vinal",
				MiddleName = "Jerrod",
				LastName = "Gabe",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Supervisor
			{
				Id = 4,
				FirstName = "Carissa",
				MiddleName = "Novalee",
				LastName = "Austen",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Supervisor
			{
				Id = 5,
				FirstName = "Brady",
				MiddleName = "Fay",
				LastName = "Micah",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			}
		);
	}

	private void SeedEmployees()
	{
		modelBuilder.Entity<Employee>().HasData(
			new Employee
			{
				Id = 1,
				FirstName = "Dax",
				MiddleName = "Kipton",
				LastName = "Mcclellan",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 2,
				FirstName = "Carter",
				MiddleName = "Konnor",
				LastName = "Merritt",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{	
				Id = 3,
				FirstName = "Finnian",
				MiddleName = "Gianluca",
				LastName = "Raymond",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 4,
				FirstName = "Sara",
				MiddleName = "Leilany",
				LastName = "Stanton",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 5,
				FirstName = "Darion",
				MiddleName = "Zavion",
				LastName = "Fournier",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 6,
				FirstName = "Charlee",
				MiddleName = "Leilany",
				LastName = "Lake",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 7,
				FirstName = "Dario",
				MiddleName = "Reese",
				LastName = "Durham",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 8,
				FirstName = "Kyron",
				MiddleName = "Sterling",
				LastName = "Messer",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 9,
				FirstName = "Alek",
				MiddleName = "Jakoby",
				LastName = "White",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 10,
				FirstName = "Kenna",
				MiddleName = "Janely",
				LastName = "Mccarty",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 11,
				FirstName = "Kassandra",
				MiddleName = "Dulce",
				LastName = "Drake",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 12,
				FirstName = "Jackson",
				MiddleName = "Nova",
				LastName = "Salgado",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 13,
				FirstName = "Hasan",
				MiddleName = "Elias",
				LastName = "Meyer",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 14,
				FirstName = "Rosemary",
				MiddleName = "Camryn",
				LastName = "Yeager",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 15,
				FirstName = "Dominic",
				MiddleName = "Gilberto",
				LastName = "Mccarty",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 16,
				FirstName = "Katarina",
				MiddleName = "Dalia",
				LastName = "Crosby",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 17,
				FirstName = "Wren",
				MiddleName = "Linda",
				LastName = "Parsons",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 18,
				FirstName = "Julie",
				MiddleName = "Ansley",
				LastName = "Preston",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 19,
				FirstName = "Tyce",
				MiddleName = "Zaine",
				LastName = "Hackett",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 20,
				FirstName = "Kaiden",
				MiddleName = "Josiah",
				LastName = "Simpson",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			},
			new Employee
			{
				Id = 21,
				FirstName = "Trae",
				MiddleName = "Elliott",
				LastName = "Lehman",
				DateOfBirth = new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local)
			}
		);
	}
}
