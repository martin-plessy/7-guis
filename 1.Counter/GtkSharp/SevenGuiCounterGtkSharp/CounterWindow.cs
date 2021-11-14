using Gtk;

namespace SevenGuiCounterGtkSharp
{
	class CounterWindow : Window
	{
		private readonly Label CounterLabel;
		private readonly Button CounterButton;

		private int CounterValue = 0;

		public CounterWindow() : base("7 GUIs Counter GTK#")
		{
			DefaultWidth = 400;
			DefaultHeight = 200;

			Box h;
			Add(h = new Box(Orientation.Horizontal, 8)
			{
				Margin = 16
			});

			h.Add(CounterLabel = new Label
			{
				Text = "0"
			});

			h.Add(CounterButton = new Button
			{
				Label = "Count"
			});

			DeleteEvent += (s, e) => Application.Quit();
			CounterButton.Clicked += (s, e) => Count();
		}

		private void Count()
		{
			CounterLabel.Text = (++CounterValue).ToString();
		}
	}
}
