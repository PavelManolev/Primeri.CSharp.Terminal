using System;

namespace ClassExplorer
{
	class person
	{
		private string simpleString  = "Тестова променлива от клас";
		private string user = "";
		private string hiddenString = "";
		public person (string _ini)
		{
			
			getUser (_ini);
			setWelcomeTExt ();
			

		}

		private void getUser (string _ini)
		{
			if (_ini == "password1") hiddenString = "Потребител 1";
			if (_ini == "password2") hiddenString = "Потребител 2";

			user = hiddenString;
		}
		private void setWelcomeTExt ()
		{
			if (hiddenString.Length > 0)
				simpleString = "Добре дошли отново," + user + "!";
			else
				simpleString = "Вия нямате достъп до тази програма";
		}
		public string getWelcomeMessage()
		{
			return simpleString;
		}



	}


	class MainClass
	{
	 
		public static void Main (string[] args)
		{
			Console.WriteLine ("Парола: "); string _user = Console.ReadLine ();

			//Дефиниране на клас
			person _person = new person (_user);
			//Достъпване на клас
			Console.WriteLine ( _person.getWelcomeMessage () );

		}
	}
}
