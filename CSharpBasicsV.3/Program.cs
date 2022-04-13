using System;
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
            string workDir = @"D:\Homework_Lesson_5";
            Console.WriteLine(Directory.Exists(workDir)); 
            
            string notesDir = Path.Combine(workDir, "New directory 5.2");
            
            Directory.CreateDirectory(notesDir); 
            
            string noteText = Convert.ToString(DateTime.Now);
            
            string notePath = Path.Combine(notesDir, "Startup.txt");
            
            File.WriteAllText(notePath, noteText);
        }
    }
}