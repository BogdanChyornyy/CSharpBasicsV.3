using System;
using System.Diagnostics;

namespace Homework
{

	public class Program
	{
		public static void Main(string[] args)
		{
			string secret = "hello";
			Console.WriteLine("Enter password: ");
			string input = Console.ReadLine();
			if (input == secret)
			{
				Console.WriteLine("Welcome!");
			}

			Console.ReadKey(true);
		}
	}
}