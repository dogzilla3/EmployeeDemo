namespace EmployeeDemo.Core.StartupHelpers
{
	public interface IAbstractFormFactory<T>
	{
		T Create();
	}
}