namespace Interface_ovning8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Program1 program1 = new Program1();

			//Program2 program2 = new Program2();

			//program1.Run();

			//program2.Go();


			Program1 program1 = new Program1();
			Program2 program2 = new Program2();

			program1.Start();
			program2.Start();

			program1.ShowSomeInfo();


		}
	}
}
