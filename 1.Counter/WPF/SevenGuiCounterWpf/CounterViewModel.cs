using Prism.Commands;
using Prism.Mvvm;

namespace SevenGuiCounterWpf
{
	public class CounterViewModel : BindableBase
	{
		private int _counterValue;
		public int CounterValue
		{
			get => _counterValue;
			set => SetProperty(ref _counterValue, value);
		}

		public DelegateCommand ClickCommand { get; }

		public CounterViewModel()
		{
			ClickCommand = new DelegateCommand(() =>
			{
				++CounterValue;
			});
		}
	}
}
