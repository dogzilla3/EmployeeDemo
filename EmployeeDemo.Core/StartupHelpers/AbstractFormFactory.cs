using System;

namespace EmployeeDemo.Core.StartupHelpers;

public class AbstractFormFactory<T> : IAbstractFormFactory<T>
{
	private readonly Func<T> _factory;

	public AbstractFormFactory(Func<T> factory)
	{
		_factory = factory;
	}

	public T Create()
	{
		return _factory();
	}
}
