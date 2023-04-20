using EmployeeDemo.HelperInterfaces;
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
		Loaded += NewSupervisorForm_Loaded;
	}

	private void NewSupervisorForm_Loaded(object sender, RoutedEventArgs e)
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
