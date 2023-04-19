using EmployeeDemo.Core.StartupHelpers;
using EmployeeDemo.DataAccess.Implementations;
using EmployeeDemo.DataAccess.Interfaces;
using EmployeeDemo.Database;
using EmployeeDemo.ViewModels;
using EmployeeDemo.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace EmployeeDemo;

public partial class App : Application
{
	public static IHost? AppHost { get; private set; }

	[STAThread]
	public static void Main(string[] args)
	{
		AppHost = CreateHostBuilder(args).Build();
		App app = new();
		app.InitializeComponent();
		app.Run();
	}

	private static IHostBuilder CreateHostBuilder(string[] args) =>
		Host.CreateDefaultBuilder(args)
			.ConfigureServices((hostContext, services) =>
			{
				services.AddDbContext<EmployeeDemoDbContext>();
				services.AddScoped<MainWindow>();
				services.AddScoped<MainWindowViewModel>();
				services.AddFormFactory<NewEmployeeForm>();
				services.AddTransient<IEmployeeDataAccess, EmployeeDataAccess>();
				services.AddTransient<ISupervisorDataAccess, SupervisorDataAccess>();

			});

	protected override async void OnStartup(StartupEventArgs e)
	{
		await AppHost!.StartAsync();
		var startUpForm = AppHost.Services.GetRequiredService<MainWindow>();
		startUpForm.Show();
		base.OnStartup(e);
	}

	protected override async void OnExit(ExitEventArgs e)
	{
		await AppHost!.StopAsync();
		base.OnExit(e);
	}
}
