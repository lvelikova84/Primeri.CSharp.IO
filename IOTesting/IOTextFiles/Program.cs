using System;

namespace IOTextFiles
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			STable _STable = new STable ();
			IOSettings _io = new IOSettings (_STable);

		
			//за запишем файла
//			if (_io.save ()) {
//				Console.WriteLine ("Таблицата е запаметена успешно");
//			} else {
//				Console.WriteLine ("Таблицата НЕ е запаметена успешно");
//			}

			if (_io.open ()) {
				Console.WriteLine ("Таблицата е прочетена успешно");
			} else {
				Console.WriteLine ("Таблицата НЕ е прочетена успешно");
			}

			Console.WriteLine (_STable.stable[2]);

		}

	}
}
