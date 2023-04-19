using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeDemo.Core.StartupHelpers;
using EmployeeDemo.DataAccess.Interfaces;
using EmployeeDemo.Database.Models;
using EmployeeDemo.Views;
using System.Collections.ObjectModel;
using System.Security.RightsManagement;
using System.Windows.Input;

namespace EmployeeDemo.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
	[ObservableProperty]
	public ObservableCollection<Supervisor> supervisors = new();

	[ObservableProperty]
	public ObservableCollection<Employee> employees = new();

	public ICommand ClickNewEmployeeButton { get; }

	public ICommand ClickNewSupervisorButton { get; }

	public readonly IEmployeeDataAccess _employeeDataAcess;
	public readonly ISupervisorDataAccess _supervisorDataAcess;
	private readonly IAbstractFormFactory<NewEmployeeForm> _newEmployeeFormFactory;
    private readonly IAbstractFormFactory<NewSupervisorForm> _newSupervisorFormFactory;

    public MainWindowViewModel(
		ISupervisorDataAccess supervisorDataAcess,
		IEmployeeDataAccess employeeDataAcess,
		IAbstractFormFactory<NewEmployeeForm> newEmployeeFormFactory,
        IAbstractFormFactory<NewSupervisorForm> newSupervisorFormFactory)
	{
		_newEmployeeFormFactory = newEmployeeFormFactory;
		_newSupervisorFormFactory = newSupervisorFormFactory;
        ClickNewEmployeeButton = new RelayCommand(OnClickNewEmployee, CanClickNewEmployee);
        ClickNewSupervisorButton = new RelayCommand(OnClickNewSupervisor, CanClickNewSupervisor);
        _employeeDataAcess = employeeDataAcess;
		_supervisorDataAcess = supervisorDataAcess;

		foreach (Supervisor supervisor in _supervisorDataAcess.GetAll())
		{
			supervisors.Add(supervisor);
		}

		foreach (Employee employee in _employeeDataAcess.GetAll())
		{
			employees.Add(employee);
		}
	}

	private bool CanClickNewEmployee()
	{
		return true;
	}
    private bool CanClickNewSupervisor()
    {
        return true;
    }

    private void OnClickNewEmployee()
    {
        _newEmployeeFormFactory.Create().Show();
    }

    private void OnClickNewSupervisor()
	{
        _newSupervisorFormFactory.Create().Show();
	}
}
