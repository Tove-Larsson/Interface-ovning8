using System;

namespace Interface_ovning8.Extra
{
	internal class ExtraClass : IExtra1, IExtra2
	{
		int IExtra1.Run()
		{
			Console.WriteLine("Run with int");
			return 7;
		}

		void IExtra2.Run()
		{
			Console.WriteLine("Run with void");
		}
	}
}
