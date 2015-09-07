using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write ("Please insert b:");
			b = Convert.ToInt32 (Console.ReadLine ());

			//Печат на резултат
			Console.WriteLine ("\n\nResult a+b is " + (a+b).ToString()+"\n");

			string test = "1";
			test += ",2";
			test += ",100";
			test += ",4";
			test += ",5";

			Console.WriteLine ("Sybirane c+=:" + test + "\n");

			test = test.Replace (",", ";");
			Console.WriteLine ("Work with replace:" + test + "\n");

			Console.WriteLine ("3th символ:" + test.Split (';')[2]);
		}
	}
}
