using System;
using System.Diagnostics;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Let's play a game! Computer has generated a number from 1 to 5");
		Console.WriteLine("Enter a number...");
		Random random = new Random();
		int rndnum = random.Next(1, 4);
		int number = Convert.ToInt32(Console.ReadLine());
		int trying = 1;

		while (trying < 3)
		{

			if (rndnum == number)
			{
				Console.WriteLine("Congratuations! You answered rightly!");
				break;
			}
			else
			{
				int somenum = 3 - trying;
				Console.WriteLine("Oh...it's wrong...You've got " + somenum + " tryings.");
				trying++;
				number = Convert.ToInt32(Console.ReadLine());
				if (somenum == 1)
				{
					Console.WriteLine("You lost.");
				}
			}
		}
	}
}