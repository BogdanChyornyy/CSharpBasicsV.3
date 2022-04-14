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