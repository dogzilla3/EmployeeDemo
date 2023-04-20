using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using EmployeeDemo.DataAccess.Interfaces;
using EmployeeDemo.Database.Models;
using EmployeeDemo.HelperInterfaces;
using EmployeeDemo.Messages;
using System;
using System.Windows.Input;

namespace EmployeeDemo.ViewModels;

public partial class NewEmployeeFormViewModel : ObservableObject, ICloseable
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

	public readonly IEmployeeDataAccess _employeeDataAcess;

	public ICommand ClickCreateButton { get; }
	public ICommand ClickCancelButton { get; }

	public Action Close { get; set; }

	public NewEmployeeFormViewModel(IEmployeeDataAccess employeeDataAcess)
	{
		_employeeDataAcess = employeeDataAcess;
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
		Employee newEmployee = new()
		{
			FirstName = FirstName,
			MiddleName = MiddleName,
			LastName = LastName,
			DateOfBirth = DateOfBirth
		};

		_employeeDataAcess.Create(newEmployee);
		WeakReferenceMessenger.Default.Send(new UpdateEmployeeTableMessage(newEmployee));
		
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
