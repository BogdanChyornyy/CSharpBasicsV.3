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
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Homework_Lesson_5\New directory 5.3\Example.bin";

            using (BinaryWriter BW = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {                
                BW.Write(NumEnter());       
                BW.Close();      
                Console.ReadKey();
            }

        static int NumEnter()
            {
                int num = Convert.ToInt32(Console.ReadLine());
                while (num <= 0 || num > 255)
                {
                    Console.WriteLine("Uncorrect number!");
                    num = Convert.ToByte(Console.ReadLine());
                }                
                return num;
            }               
        }
    }
}