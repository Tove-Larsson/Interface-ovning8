using Interface_ovning8.Extra;

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


			/* Vad är fördelen med interfacet jämfört med hur det var från början?
			 * 
			 * Fördelen är att jag kan använda samma metodnamn på flera klasser
			 * och ändå ha möjlighet att göra olika implementationer för dessa klasser.
			 * Man kan även behandla olika klasser på samma sätt, samt slippa komma på nya metodnamn.
			 */

			Program1 program1 = new Program1();
			Program2 program2 = new Program2();

			program1.Start();
			program2.Start();

			program1.ShowSomeInfo();

			// Extradelen en instans med explicit 

			ExtraClass extraClass = new ExtraClass();

			((IExtra1)extraClass).Run();

			((IExtra2)extraClass).Run();


			// Alternativ med 2 instanser (enligt föreläsningsmaterialet)

			//IExtra1 extra1 = new ExtraClass();

			//IExtra2 extra2 = new ExtraClass();

			//extra1.Run();
			//extra2.Run();

		}
	}
}
