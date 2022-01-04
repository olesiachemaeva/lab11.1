using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            Console.WriteLine("Введите k:");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} = {1}x + {2}", y, k, b);
            Equation equation = new Equation { b = b, x = x, Ratio = k, addition = y };
            // equation.Equation();
            equation.Read(b, k, y);

        }
        struct Equation
        {

            public double b;
            public double x;
            public double Ratio; // коофицент К
            public double addition; //сложение



            public void Read(double b, double Ratio, double addition)
            {

                root();
            }

            public void root()
            {
                if (Ratio != 0) x = (addition - b) / Ratio;
                Display();
            }
            public void Display()
            {
                Console.WriteLine("Решение x : {0} ", x);
                Console.ReadKey();
            }
        }
    }
}
