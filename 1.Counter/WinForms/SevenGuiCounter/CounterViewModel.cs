using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace SevenGuiCounter
{
	public class CounterViewModel : ReactiveObject, IActivatableViewModel {
		public ViewModelActivator Activator { get; } = new();

		[ObservableAsProperty] public int CounterValue { get; }

		public ReactiveCommand<Unit, Unit> ClickCommand { get; }

		public CounterViewModel()
		{
			ClickCommand = ReactiveCommand.Create(() => {});

			this.WhenActivated(disposables =>
			{
				ClickCommand
					.Select((_, i) => i + 1)
					.ToPropertyEx(this, x => x.CounterValue)
					.DisposeWith(disposables);
			});
		}
	}
}
