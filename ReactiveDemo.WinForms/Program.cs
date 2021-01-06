using ReactiveUI;
using Splat;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ReactiveDemo
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			// A helper method that will register all classes that derive off IViewFor 
			// into our dependency injection container. ReactiveUI uses Splat for it's 
			// dependency injection by default, but you can override this if you like.
			Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());

			Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
