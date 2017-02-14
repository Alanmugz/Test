using System;
using NUnit.Framework;


namespace TravisTest.UT
{
	[TestFixture]
	public class Class1
	{
		private Test c_SUT;


		[SetUp]
		public void SetUp()
		{
			this.c_SUT = new Test();
		}


		[Test]
		public void VerifyAdd()
		{
			var _actual = this.c_SUT.Add(2, 3);

			Assert.AreEqual(5, _actual);
		}
	}
}
