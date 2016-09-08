using System;
using HelloWorldService;
using HelloWorldWriter;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			IHelloWorldWriter writer = HelloWorldWriterFactory.GetInstance(HelloWorldWriterType.Console);
			writer.Write("Hello World");

			writer = HelloWorldWriterFactory.GetInstance(HelloWorldWriterType.Database);
			writer.Write("Hello World");
			Environment.Exit(0);
		}
	}
}
