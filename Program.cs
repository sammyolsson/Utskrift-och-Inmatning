using System;

namespace Utskrift_och_Inmatning
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Vänligen skriv ditt förnamn: "); //Ber användaren skriva in sitt förnamn
			string firstName = Console.ReadLine(); //Deklarerar variabeln som ska innehålla användarens förnamn

			Console.Write("Vänligen skriv ditt efternamn: "); //Ber användaren skriva in sitt efternamn
			string lastName = Console.ReadLine(); //Deklarerar variabeln som ska innehålla användarens efternamn

			Console.WriteLine("Välkommen in i värmen " + firstName + " " + lastName + "!"); //Adderar välkomstmedelande med firstName och lastName-variablar

			Console.Write("Vänligen skriv din ålder: "); //Ber användaren skriva in sin ålder
			string age = Console.ReadLine();//Deklarerar variabeln som ska innehålla användarens ålder
			int nr = Convert.ToInt32(age); //Konverterar från string till int med hjälp av ToInt32-metod
			Console.WriteLine("Du är med andra ord " + (nr * 365) + " dagar ung"); //Adderar medelande med konverterad string samt uträkning

		}
	}
}
