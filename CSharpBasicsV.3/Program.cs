using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework_4_part_1
{
    class Program
    {
        enum Season
        {
            winter,
            spring,
            summer,
            autumn
        }

        static void Main()
        {
            object r = SeasonDefinition();
            Console.WriteLine("Your chosen season is: " + r);            
        }

        static object SeasonDefinition()
        {
            string seasName = Convert.ToString(SerNumToSeason());
            if (seasName == "winter")
            {
                seasName = "Зима";
            }
            else if (seasName == "spring")
            {
                seasName = "Весна";
            }
            else if (seasName == "summer")
            {
                seasName = "Лето";
            }
            else
            {
                seasName = "Осень";
            }

            return seasName;
        }

        static object SerNumToSeason()
        {            
            int serNum = Convert.ToInt16(CorrectInt());
            if (serNum > 0 && serNum < 3 || serNum == 12)
            {
                serNum = 0; //winter
            }
            else if (serNum > 2 && serNum < 6)
            {
                serNum = 1; //spring
            }
            else if (serNum > 5 && serNum < 9)
            {
                serNum = 2; //summer
            }
            else
            {
                serNum = 3; //autumn
            }

            Type enumType = Season.spring.GetType();
            int example = serNum;
            return Enum.ToObject(enumType, example);            
        }

        static int CorrectInt()
        {
            Console.WriteLine("Enter serial number of month, from season u've chosen: ");

            int num = int.Parse(Console.ReadLine());

            while (num < 1 || num > 12)
            {
                Console.WriteLine("Your number is not correct. You should to chose number from 1 to 12. Try again.");
                num = int.Parse(Console.ReadLine());
            }
            return num;
        }
    }
}