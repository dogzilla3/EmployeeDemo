using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using EmployeeDemo.Core.StartupHelpers;
using EmployeeDemo.DataAccess.Interfaces;
using EmployeeDemo.Database.Models;
using EmployeeDemo.Messages;
using EmployeeDemo.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace EmployeeDemo.ViewModels;

public partial class MainWindowViewModel : 
	ObservableObject, 
	IRecipient<UpdateEmployeeTableMessage>,
	IRecipient<UpdateSupervisorTableMessage>
{
	[ObservableProperty]
	public Supervisor selectedSupervisor;

	[ObservableProperty]
	public Employee selectedEmployee;

    [ObservableProperty]
	public ObservableCollection<Supervisor> supervisors = new();

	[ObservableProperty]
	public ObservableCollection<Employee> employees = new();

	//public ICommand ClickNewEmployeeButton { get; }
	//public ICommand ClickNewSupervisorButton { get; }
	//public ICommand ClickFireSupervisorButton { get; }
	//public ICommand ClickDemoteSupervisorButton { get; }
	//public ICommand ClickFireEmployeeButton { get; }
	//public ICommand ClickPromoteEmployeeButton { get; }

	public readonly IEmployeeDataAccess _employeeDataAcess;
	public readonly ISupervisorDataAccess _supervisorsDataAcess;

	private readonly IAbstractFormFactory<NewEmployeeForm> _newEmployeeFormFactory;
    private readonly IAbstractFormFactory<NewSupervisorForm> _newSupervisorFormFactory;

    public MainWindowViewModel(
		ISupervisorDataAccess supervisorDataAcess,
		IEmployeeDataAccess employeeDataAcess,
		IAbstractFormFactory<NewEmployeeForm> newEmployeeFormFactory,
        IAbstractFormFactory<NewSupervisorForm> newSupervisorFormFactory)
	{
		//ClickNewEmployeeButton = new RelayCommand(OnClickNewEmployee, CanClickNewEmployee);
		//ClickNewSupervisorButton = new RelayCommand(OnClickNewSupervisor, CanClickNewSupervisor);
		//ClickFireSupervisorButton = new RelayCommand(OnClickFireSupervisor, CanClickFireSupervisor);
		//ClickDemoteSupervisorButton = new RelayCommand(OnClickDemoteSupervisor, CanClickDemoteSupervisor);
		//ClickFireEmployeeButton = new RelayCommand(OnClickFireEmployee, CanClickFireEmployee);
		//ClickPromoteEmployeeButton = new RelayCommand(OnClickPromoteEmployee, CanClickPromoteEmployee);

		_newEmployeeFormFactory = newEmployeeFormFactory;
		_newSupervisorFormFactory = newSupervisorFormFactory;
        
        _employeeDataAcess = employeeDataAcess;
		_supervisorsDataAcess = supervisorDataAcess;

		WeakReferenceMessenger.Default.Register<UpdateEmployeeTableMessage>(this);
		WeakReferenceMessenger.Default.Register<UpdateSupervisorTableMessage>(this);

		FetchEmployees();
		FetchSupervisors();
	}

	private bool CanClickNewEmployee()
	{
		return true;
	}

    private bool CanClickNewSupervisor()
    {
        return true;
    }

	private bool CanClickFireSupervisor()
	{
		return true;
	}

	private bool CanClickFireEmployee()
	{
		return true;
	}

	private bool CanClickPromoteEmployee()
	{
		return true;
	}

	private bool CanClickDemoteSupervisor()
	{
		return true;
	}

	[RelayCommand]
	private void ClickNewEmployee()
    {
		Trace.WriteLine("Test");
		_newEmployeeFormFactory.Create().Show();
	}

	[RelayCommand]
	private void ClickNewSupervisor()
	{
		Trace.WriteLine("Test");
		_newSupervisorFormFactory.Create().Show();
	}

	[RelayCommand]
	private void ClickFireSupervisor(int id)
	{
		//this.Clic
	}

	[RelayCommand]
	private void ClickDemoteSupervisor(int id)
	{
		Trace.WriteLine("Demoting Supervisor: " + id);
	}

	[RelayCommand]
	private void ClickFireEmployee(int id)
	{
		
	}

	[RelayCommand]
	private void ClickPromoteEmployee(int id)
	{
		
	}

	private void FetchEmployees(int? supervisorId)
	{
		Employees.Clear();
		foreach (Employee employee in _employeeDataAcess.GetAll())
		{
			if(SelectedSupervisor != null && SelectedSupervisor.Id == employee.SupervisorId.Value)
			{
				Employees.Add(employee);
			}
		}
	}

	private void FetchEmployees()
	{
		foreach (Employee employee in _employeeDataAcess.GetAll())
		{
			Employees.Add(employee);
		}
	}

	private void FetchSupervisors()
	{
		Supervisors.Clear();
		foreach (Supervisor super in _supervisorsDataAcess.GetAll())
		{
			Supervisors.Add(super);
		}
	}

	public void Receive(UpdateEmployeeTableMessage message)
	{
		FetchEmployees(null);
	}

	public void Receive(UpdateSupervisorTableMessage message)
	{
		FetchSupervisors();
	}

    partial void OnSelectedSupervisorChanged(Supervisor supervisor)
    {
		FetchEmployees(supervisor.Id);
    }
}
