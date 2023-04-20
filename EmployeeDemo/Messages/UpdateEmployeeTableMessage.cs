using CommunityToolkit.Mvvm.Messaging.Messages;
using EmployeeDemo.Database.Models;


namespace EmployeeDemo.Messages;

public class UpdateEmployeeTableMessage : ValueChangedMessage<Employee>
{
	public UpdateEmployeeTableMessage(Employee value) : base(value)
	{

	}
}
