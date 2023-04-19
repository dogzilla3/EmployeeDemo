using EmployeeDemo.ViewModels;
using System.Windows;


namespace EmployeeDemo.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindowViewModel ViewModel { get; }

	public MainWindow(MainWindowViewModel viewModel)
	{
		DataContext = ViewModel = viewModel;
		InitializeComponent();
	}
}
