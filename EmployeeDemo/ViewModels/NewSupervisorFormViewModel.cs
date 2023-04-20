using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeDemo.DataAccess.Interfaces;
using System.Windows.Input;
using System;
using EmployeeDemo.HelperInterfaces;
using EmployeeDemo.DataAccess.Implementations;
using EmployeeDemo.Database.Models;

namespace EmployeeDemo.ViewModels;

public partial class NewSupervisorFormViewModel : ObservableObject, ICloseable
{
	public int Id { get; set; }

	[ObservableProperty]
	public string _firstName;
	[ObservableProperty]
	public string _middleName;
	[ObservableProperty]
	public string _lastName;
	[ObservableProperty]
	public DateTime _dateOfBirth;

	public readonly ISupervisorDataAccess _supervisorDataAcess;

	public ICommand ClickCreateButton { get; }
	public ICommand ClickCancelButton { get; }

	public Action Close { get; set; }

	public NewSupervisorFormViewModel(ISupervisorDataAccess supervisorDataAcess)
	{
		_supervisorDataAcess = supervisorDataAcess;
		ClickCreateButton = new RelayCommand(OnClickCreate, CanClickCreate);
		ClickCancelButton = new RelayCommand(OnClickCancel, CanClickCancel);
	}

	private bool CanClickCancel()
	{
		return true;
	}

	private bool CanClickCreate()
	{
		return true;
	}

	private void OnClickCreate()
	{
		Supervisor newSupervisor = new()
		{
			FirstName = FirstName,
			MiddleName = MiddleName,
			LastName = LastName,
			DateOfBirth = DateOfBirth
		};

		_supervisorDataAcess.Create(newSupervisor);
		CloseWindow();
	}

	private void OnClickCancel()
	{
		CloseWindow();
	}

	void CloseWindow()
	{
		Close?.Invoke();
	}
}
