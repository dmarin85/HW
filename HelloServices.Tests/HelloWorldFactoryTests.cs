using System;
using HelloWorldService;
using HelloWorldWriter;
using NUnit.Framework;

namespace HelloServices.Tests
{
	/// <summary>
	/// These tests have no real values. They just demonstrate the ability to write unit test
	/// </summary>
	[TestFixture]
    public class HelloWorldFactoryTests
    {
		[Test]
		public void GetInstance_Console_ReturnsAConsoleHelloWorldWriter()
		{
			IHelloWorldWriter writer = null;

			writer = HelloWorldWriterFactory.GetInstance(HelloWorldWriterType.Console);

			Assert.IsTrue(writer is IHelloWorldWriter);
			Assert.IsTrue(writer is ConsoleHelloWorldWriter);
			Assert.IsFalse(writer is DataBaseHelloWorldWriter);
		}

		[Test]
		public void GetInstance_Unkbown_ThrowsAnNotImplementedException()
		{
			Assert.Throws<NotImplementedException>(() => HelloWorldWriterFactory.GetInstance(HelloWorldWriterType.Unknown));
		}
    }
}
