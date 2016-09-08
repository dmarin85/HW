using System;
using System.Configuration;
using HelloWorldService;
using HelloWorldWriter;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			HelloWorldWriterType helloWorldWriterType = (HelloWorldWriterType)Enum.Parse(typeof(HelloWorldWriterType), ConfigurationManager.AppSettings["WriterType"] ?? "0");

			IHelloWorldWriter writer = HelloWorldWriterFactory.GetInstance(helloWorldWriterType);
			writer.Write("Hello World");
			Environment.Exit(0);
		}
	}
}
