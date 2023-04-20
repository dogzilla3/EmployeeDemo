using EmployeeDemo.Database.Models;
using System.Collections.Generic;


namespace EmployeeDemo.DataAccess.Interfaces;

public interface IEmployeeDataAccess
{
    public List<Employee> GetAll();
    public void Create(Employee employee);
}
