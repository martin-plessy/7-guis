using System;
using NUnit.Framework;

namespace SevenGuiCounter.Tests
{
	public class CounterViewModelTests
	{
		private CounterViewModel vm;

		[SetUp]
		public void SetUp() {
			vm = new();
			vm.Activator.Activate();
		}

		[Test]
		public void CounterValue_starts_at_zero()
		{
			Assert.AreEqual(0, vm.CounterValue);
		}

		[Test]
		public void CounterValue_is_incremented_on_click()
		{
			vm.ClickCommand.Execute().Subscribe();
			vm.ClickCommand.Execute().Subscribe();
			vm.ClickCommand.Execute().Subscribe();

			Assert.AreEqual(3, vm.CounterValue);
		}
	}
}
