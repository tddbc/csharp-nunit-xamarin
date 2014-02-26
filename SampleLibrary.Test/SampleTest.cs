using NUnit.Framework;
using System;

namespace SampleLibrary.Test
{
	[TestFixture]
	public class SampleTest
	{
		[TestCase]
		public void TestSay()
		{
			var sample = new Sample();
			Assert.AreEqual("Hello TDD Boot Camp!", sample.Say());
		}
	}
}

