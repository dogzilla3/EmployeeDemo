using EmployeeDemo.ViewModels;
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
	}
}
