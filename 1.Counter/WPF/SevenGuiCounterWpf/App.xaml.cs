using System.Windows;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;

namespace SevenGuiCounterWpf
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : PrismApplication
	{
		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
		}

		protected override void ConfigureViewModelLocator()
		{
			base.ConfigureViewModelLocator();

			ViewModelLocationProvider.Register<CounterWindow, CounterViewModel>();
		}

		protected override Window CreateShell()
		{
			return Container.Resolve<CounterWindow>();
		}
	}
}
