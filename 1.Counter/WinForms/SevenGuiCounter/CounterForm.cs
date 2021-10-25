using ReactiveUI;
using System.Drawing;
using System.Windows.Forms;
using System.Reactive.Disposables;

namespace SevenGuiCounter
{
	public class CounterForm : Form, IViewFor<CounterViewModel>
	{
		public CounterViewModel? ViewModel { get; set; }
		object? IViewFor.ViewModel { get => ViewModel; set => ViewModel = value as CounterViewModel; }

		private readonly TextBox CounterBox;
		private readonly Button CounterButton;

		private const int PADDING = 12;

		public CounterForm()
		{
			SuspendLayout();

			ViewModel = new();
			Text = "7 GUIs Counter WinForms .NET 5";

			Controls.Add(CounterBox = new TextBox
			{
				Text = "0",
				ReadOnly = true,
				Location = new Point(PADDING, PADDING),
				AutoSize = true,
				TabIndex = 2,
			});

			Controls.Add(CounterButton = new Button
			{
				Text = "Count",
				Location = new Point(CounterBox.Width + PADDING * 2, PADDING),
				AutoSize = true,
				TabIndex = 1,
			});

			ResumeLayout(performLayout: true);

			this.WhenActivated(disposables =>
			{
				this.OneWayBind(ViewModel, vm => vm.CounterValue, v => v.CounterBox.Text).DisposeWith(disposables);
				this.BindCommand(ViewModel, vm => vm.ClickCommand, v => v.CounterButton).DisposeWith(disposables);
			});
		}
	}
}
