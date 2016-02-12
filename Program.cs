using System;

namespace Use_data
{
	class MainClass
	{
		enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
		public static void Main (string[] args)
		{
			Console.WriteLine ((int)DialogResult.YES); //0
			Console.WriteLine ((int)DialogResult.NO); //1
			Console.WriteLine ((int)DialogResult.CANCEL); //2
			Console.WriteLine ((int)DialogResult.CONFIRM); //3
			Console.WriteLine ((int)DialogResult.OK); //4
		}
	}
}
