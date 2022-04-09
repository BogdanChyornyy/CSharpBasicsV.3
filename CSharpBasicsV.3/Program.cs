using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework_4_part_1
{
    class Program
    {
        //        Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
        //возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести
        //результат на экран.
        static void Main(string[] args)
        {
            int ansver = Split();
            Console.WriteLine(ansver);
        }

        static int Split()
        {
            string SomeString = Console.ReadLine();
            string[] SplitString = SomeString.Split(' ');

            int el = 0;
            for (int i = 0; i < SplitString.Length; i++)
            {
                int m = Convert.ToInt32(SplitString[i]);
                el += m;
            }
            return el;
        }
    }
}