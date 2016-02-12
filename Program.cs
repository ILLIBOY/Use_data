using System;

namespace Use_data
{
	class MainClass
	{
		enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

		public static void Main (string[] args)
		{
			DialogResult result = DialogResult.YES;

			Console.WriteLine (result);
			Console.WriteLine (result == DialogResult.YES); //0
			Console.WriteLine (result == DialogResult.NO); //1
			Console.WriteLine (result == DialogResult.CANCEL); //2
			Console.WriteLine (result == DialogResult.CONFIRM); //3
			Console.WriteLine (result == DialogResult.OK); //4
		}
	}
}
