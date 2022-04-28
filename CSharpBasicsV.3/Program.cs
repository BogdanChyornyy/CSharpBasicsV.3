using System;
using System.Diagnostics;

public class Program
{
	public static void Main()
	{
		string start = "open";
		while (start == "open")
        {
			ProcessKiller();
			Console.WriteLine("Program process will be continued, do you agree?");
			Console.WriteLine("yes/no");
			string point = Console.ReadLine();
			if (point == "no")
            {
				Console.WriteLine("Ending program...");
				break;
            }            
        }
				
	}

	public static void ProcessKiller()
	{
		Process chosen = Process.GetProcessById(Int32.Parse(ListOfProcesses()));
		chosen.Kill();
	}

	public static string ListOfProcesses()
	{
		Process[] allprocesses = Process.GetProcesses();

		foreach (var process in allprocesses)
		{
			// выводим id и имя процесса
			Console.WriteLine("ID:" + process.Id + " Name: " + process.ProcessName);
		}

		Console.WriteLine("Enter processes ID to close...");
		string id = Console.ReadLine();
		return id;
	}
}