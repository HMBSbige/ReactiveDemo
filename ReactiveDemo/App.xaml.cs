using ReactiveUI;
using Splat;
using System.Reflection;

namespace ReactiveDemo;

public partial class App
{
	public App()
	{
		// A helper method that will register all classes that derive off IViewFor 
		// into our dependency injection container. ReactiveUI uses Splat for it's 
		// dependency injection by default, but you can override this if you like.
		Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());
	}
}
