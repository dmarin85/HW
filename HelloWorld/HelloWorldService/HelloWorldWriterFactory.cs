using System;
using HelloWorldWriter;

namespace HelloWorldService
{
	public static class HelloWorldWriterFactory
    {
		public static IHelloWorldWriter GetInstance(HelloWorldWriterType type)
		{
			switch (type)
			{
				case HelloWorldWriterType.Console:
					return new ConsoleHelloWorldWriter();
				case HelloWorldWriterType.Database:
					return new DataBaseHelloWorldWriter();
				default:
					throw new NotImplementedException();
			}
		}
    }
}
