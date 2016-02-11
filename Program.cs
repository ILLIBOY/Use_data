using System;

namespace Use_data
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a = 123;
			object b = (object)a; //a unboxing, save to b(heap);
			int c = (int)b; //b unboxing, save to c(stack);

			Console.WriteLine (a);
			Console.WriteLine (b);
			Console.WriteLine (c);

			double x = 3.141592;
			object y = x; //x unboxing, save to y(heap);
			int z = (double)y; //y unboxing, save to z(stack);

			Console.WriteLine (x);
			Console.WriteLine (y);
			Console.WriteLine (z);
		}
	}
}
