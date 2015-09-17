using System;
using System.Collections.Generic;
namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string _userinput="";

			List<int> _list = new List<int> ();

			_list.Add (5);
			_list.Add (3);
			_list.Add (9);

			//Потребителски вход
			do {
				Console.Write ("?");
				_userinput=Console.ReadLine ();


				//Добавяне на стойности в List-a
				// add int



				if (_userinput.ToLower().Contains ("add"))  //add 5
				{
							try
							{
									int _add=0;
									if (int.TryParse(_userinput.Split (' ')[1], out _add)) //преобразува входа в int променлива
									{
										_list.Add (_add);
									}
								Console.WriteLine ("\n");

							}catch {}
				}

				//Преглед на list-a
				if (_userinput.Contains ("show")) 
				{
					Console.Write ("Списък: ");

					foreach (int value in _list)
					{
						Console.Write (value.ToString ()+", ");
					}


//					for (int i=0; i<_list.Count;i++)
//					{
//						
//						Console.Write (_list[i]);
//						if (i!=_list.Count-1) Console.Write (", ");  //не слага запетайка след последния елемент на листа
//					}
					Console.WriteLine ("\n");
				}

				//размер на Лист-а
				if (_userinput.ToLower().Contains ("size"))
				{
					Console.WriteLine ("размер на списъка: "+ _list.Count.ToString ()+"\n" );    //изписваме размера на листа
				}

			} while(_userinput != "exit");
		

		}
	}
}
