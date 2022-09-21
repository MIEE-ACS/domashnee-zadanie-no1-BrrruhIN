using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Vrem;
            double L, R, S;
            Console.WriteLine("Введите L:");
            Vrem = Console.ReadLine();
            L = Convert.ToDouble(Vrem);
            if (L < 0)
            {
                Console.WriteLine("Ошибка. Длина окружности меньше нуля.");
            }
            else
            {
                R = L / (2 * Math.PI);
                S = Math.PI * Math.Pow(R, 2);
                R = Math.Round(R, 3);
                S = Math.Round(S, 3);

                Console.WriteLine("Радиус круга равен " + R);
                Console.WriteLine("Площадь круга равна " + S);
            }
        }
    }
}
