using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program174
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Оценка (A/B/C/D/F): ");
            string  grade = Console.ReadLine()?.Trim().ToUpper();
            if (string.IsNullOrEmpty(grade) || grade.Length != 1)
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string fivePoint;
            switch (grade[0])
            {
                case 'A': fivePoint = "5 (отлично)"; break;
                case 'B': fivePoint = "4 (хорошо)"; break;
                case 'C': fivePoint = "3 (удовлетворительно)"; break;
                case 'D': fivePoint = "3 (слабо)"; break;
                case 'F': fivePoint = "2 (неудовлетворительно)"; break;
                default:
                    Console.WriteLine("Неверная оценка.");
                    return;
            }
            Console.WriteLine(fivePoint);
        }
    }
}
