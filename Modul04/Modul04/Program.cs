using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			String[ , ] _table = {
				{"Иван",   "Георгиев ", "19" },
				{"Васил",   "Праматаров ", "23" },
				{"Павел",   "Манолев ", "37" },
				{"Момчил",   "Пеков ", "33" },
				{"Петя",   "Коритарова ", "28" },
				{"Ева",   "Александрова ", "35" }};
			//Антетка на таблица
			Console.WriteLine ("Име".PadRight(14)+"Фамилия".PadRight(14)+"Години".PadRight(14));
			Console.WriteLine ("========================================");

			Console.WriteLine (_table.Length);
			// Тяло на таблица
			for ( int i=0; i<_table.Length/3 ; i++ )
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write ( _table[i,j].PadRight(14));
				}
				Console.WriteLine ();
			}
		}
	}
}
