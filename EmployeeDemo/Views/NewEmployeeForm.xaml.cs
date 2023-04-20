using EmployeeDemo.HelperInterfaces;
using EmployeeDemo.ViewModels;
using System;
using System.Windows;


namespace EmployeeDemo.Views;

/// <summary>
/// Interaction logic for NewEmployeeForm.xaml
/// </summary>
public partial class NewEmployeeForm : Window
{
	public NewEmployeeFormViewModel ViewModel { get; }

	public NewEmployeeForm(NewEmployeeFormViewModel viewModel)
    {
		DataContext = ViewModel = viewModel;
		InitializeComponent();
		Loaded += NewEmployeeForm_Loaded;
	}

	private void NewEmployeeForm_Loaded(object sender, RoutedEventArgs e)
	{
		if (DataContext is ICloseable viewModel)
		{
			viewModel.Close += () =>
			{
				this.Close();
			};
		}
	}
}
