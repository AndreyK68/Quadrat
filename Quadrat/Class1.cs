using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrat
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Решение квадратного уровнения");
            Console.WriteLine("Формула: ax2+bx+c=0");
            // ввод данных
            Console.WriteLine();
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            double x1, x2;
            // Находим дискриминант
            double diskr = Math.Pow(b, 2) - 4 * a * c;
            if (diskr < 0) 
            {
                Console.WriteLine();
                Console.WriteLine("Дискриминант = {0}", diskr);
                Console.WriteLine("Дискриминант отрицательный - корней нет");
                Console.WriteLine();
            }
            else
            {
                x1 = -b + Math.Sqrt(diskr) / (2 * a);
                x2 = -b - Math.Sqrt(diskr) / (2 * a);
                Console.WriteLine();
                Console.WriteLine($"x1= {x1};  x2= {x2}");
                Console.WriteLine();
            }
            Console.WriteLine("Введите натуральное число для разлжения на простые множители");
            Console.WriteLine("num = ");
            uint num = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {num} ");
            int dvoek = 0;
            int troek = 0;
            int pyaterok = 0;
            int semerok = 0;
            //int ostatok = 0;
            //int count1 = 1;
            //while (num != 1)
            Console.Write("{0} = 1", num);
            for (int i = 0; i <= 1; i++)
            {
                if(i==1 & num != 1) Console.Write(" * {0}", num);               
                while (num % 2 == 0)
                {
                    num /= 2;
                    Console.Write(" * {0}", 2);                    
                    dvoek++;                    
                }
                if (num % 3 == 0)
                {
                    num /= 3;
                    Console.Write(" * {0}", 3);
                    troek++;
                    i--;
                }
                if (num % 5 == 0)
                {
                    num /= 5;
                    Console.Write(" * {0}", 5);
                    pyaterok++;
                    i--;
                }
                if (num % 7 == 0)
                {
                    num /= 7;
                    Console.Write(" * {0}", 7);
                    semerok++;
                    i--;
                }              

            }            
            Console.WriteLine();
            Console.WriteLine("двоек = {0}", dvoek);
            Console.WriteLine("Троек = {0}", troek);
            Console.WriteLine("Пятёрок = {0}", pyaterok);
            Console.WriteLine("Семёрок = {0}", semerok);
            Console.WriteLine();
            if ((dvoek + troek + pyaterok + semerok)==0) Console.WriteLine("Вы ввели простое число");
            Console.WriteLine();
        }

    }
}
