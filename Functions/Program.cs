using System;

namespace Functions
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("sisesta esimist arvu");
			int userNumberOne = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("sisesta teist arvu");
			int userNumberTwo = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("vali tehe (sisesta '+', '-', '*' või '/')");
			char userOprator = Convert.ToChar(Console.ReadLine());

			switch (userOprator)
			{
				case '+':
					AddTwoNumbers(userNumberOne, userNumberTwo);
					break;
				case '/' :
					DivideTwoNumbers(userNumberOne, userNumberTwo);
					break;
			
				case '-':
					MinusTwoNumbers(userNumberOne, userNumberTwo);
					break;
				case '*':
					MultiTwoNumbers(userNumberOne, userNumberTwo);
					break;
				default:
					Console.WriteLine("Kena päeva!");
					break;
			}

		}
		public static void AddTwoNumbers(int x, int y)
		{
			int result = x + y;
			Console.WriteLine(result);
		}

		public static void DivideTwoNumbers(double x, double y)
		{
			double result = x / y;
			Console.WriteLine(result);
		}
		public static void MinusTwoNumbers(int x, int y)
		{
			int result = x - y;
			Console.WriteLine(result);
		}

		public static void MultiTwoNumbers(double x, double y)
		{
			double result = x * y;
			Console.WriteLine(result);
		}

	}
}
