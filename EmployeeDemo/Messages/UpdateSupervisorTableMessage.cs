using CommunityToolkit.Mvvm.Messaging.Messages;
using EmployeeDemo.Database.Models;


namespace EmployeeDemo.Messages;

public class UpdateSupervisorTableMessage : ValueChangedMessage<Supervisor>
{
	public UpdateSupervisorTableMessage(Supervisor value) : base(value)
	{

	}
}
