using System;

namespace EmployeeDemo.HelperInterfaces;

public interface ICloseable
{
	Action Close { get; set; }
}
