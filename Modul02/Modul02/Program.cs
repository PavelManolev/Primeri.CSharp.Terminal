﻿using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Задачи от модул02 Видео 02
			int c= 0 , d = 0, e= 0;
			string programe_zadacha = "Модул2 - първа задача";

			//задаване на стойностти на a и b
			Console.WriteLine (programe_zadacha);
			c = Convert.ToInt32 (Console.ReadLine ());
			d = Convert.ToInt32 (Console.ReadLine ());

			e = c;
			c = d;
			d = e;

			Console.WriteLine (c);
			Console.WriteLine (d);

			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02-Primeri";
			String program_version = "1.0";

			//Събиране на числа

			a = 10;
			b = 5;

			sum = a + b;

			//За програмата 

			Console.WriteLine (program_name);
			Console.WriteLine ("Versia "+program_version+"\n\n");

			//Писане на конзолата
			Console.Write ( a);
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write ( " = ");
			Console.WriteLine (sum ); 

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b; 
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на -=");
			a -= b; 
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на *=");
			a *= b; 
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на ++");
			a ++; 
			Console.WriteLine ( a );

			a = 15; b=10;

			Console.WriteLine ("\nStandartno Delene");

			Console.WriteLine ( a/b ); //1

			Console.WriteLine ("\nHwashtane na ostatyk");

			Console.WriteLine ( a%b ); //5, 1.5


}
	}
}