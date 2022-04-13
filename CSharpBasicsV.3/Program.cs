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
            
            string notesDir = Path.Combine(workDir, "New directory 5.1");
            
            Directory.CreateDirectory(notesDir); 
            // Создаем вложенную директорию
            string noteText = Console.ReadLine(); //Ввод данных в блокнот через консоль
            
            string notePath = Path.Combine(notesDir, "EnterSomeText.txt");
            
            File.WriteAllText(notePath, noteText);
        }
    }
}