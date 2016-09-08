using System;

namespace HelloWorldWriter
{
	public class ConsoleHelloWorldWriter : IHelloWorldWriter
	{
		public void Write(string text)
		{
			Console.WriteLine(string.Format("{0} from ConsoleHelloWorldWriter", text));
		}
	}
}
