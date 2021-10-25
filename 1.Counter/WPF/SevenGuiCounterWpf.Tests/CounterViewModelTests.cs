using NUnit.Framework;

namespace SevenGuiCounterWpf.Tests
{
	public class CounterViewModelTests
	{
		private CounterViewModel vm;

		[SetUp]
		public void SetUp()
		{
			vm = new();
		}

		[Test]
		public void CounterValue_starts_at_zero()
		{
			Assert.AreEqual(0, vm.CounterValue);
		}

		[Test]
		public void CounterValue_increments_on_click()
		{
			vm.ClickCommand.Execute();
			vm.ClickCommand.Execute();
			vm.ClickCommand.Execute();

			Assert.AreEqual(3, vm.CounterValue);
		}
	}
}
