using System;

namespace HelloWorldWriter
{
	public class DataBaseHelloWorldWriter : IHelloWorldWriter
	{
		public void Write(string text)
		{
			Console.WriteLine(string.Format("{0} has been added to the database", text));
		}
	}
}
