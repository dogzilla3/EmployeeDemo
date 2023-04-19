using EmployeeDemo.ViewModels;
using System.Windows;


namespace EmployeeDemo.Views;

/// <summary>
/// Interaction logic for NewEmployeeForm.xaml
/// </summary>
public partial class NewSupervisorForm : Window
{
	public NewSupervisorFormViewModel ViewModel { get; }

	public NewSupervisorForm(NewSupervisorFormViewModel viewModel)
    {
		DataContext = ViewModel = viewModel;
		InitializeComponent();
	}
}
