﻿using System;

namespace Use_data
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			sbyte a = 127;
			Console.WriteLine (a);

			int b = (int)a;
			Console.WriteLine (b);

			int x = 128;
			Console.WriteLine (x);

			sbyte y = (sbyte)x;
			Console.WriteLine (y);
		}
	}
}
