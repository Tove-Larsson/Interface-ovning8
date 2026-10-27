using System;

namespace Interface_ovning8
{
	internal class Program1 : IStart, IAnother
	{

		//public void Run()
		//{
		//	Console.WriteLine("Nu kör vi program 1");
		//}

		public void Start()
		{
			Console.WriteLine("Nu kör vi program 1");
		}

		public void ShowSomeInfo()
		{
			Console.WriteLine("Detta är extra information från program 1");
		}

	}
}
