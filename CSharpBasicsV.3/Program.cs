using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework_4_part_1
{
    class Program
    {
        static void Main()
        {
            string FLP = GetFullName();
            Print(FLP);
        }
        static string GetFullName()
        {
            Print("Hi! Enter your personal data, please:)");
            Print("Enter u're first name:");
            string firstName = ReadString();
            Print("Enter u're last name:");
            string lastName = ReadString();
            Print("Enter u're patronymic:");
            string patronymic = ReadString();
            Print("Thx:) You've got pretty name! Youre full name is: ");
            return lastName + " " + firstName + " " + patronymic;
        }
        static string Enter()
        {
            return Console.ReadLine();
        }
        static void Print(string words)
        {
            Console.WriteLine(words);
        }
        static string ReadString()
        {
            return Convert.ToString(Enter());
        }
    }
}