using System;
using System.Security.Cryptography;

namespace Lab5_2
{
    class Triangle
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public double SemiPerimeter() => (_firstSide + _secondSide + _thirdSide)/2;

        public double Area() => Math.Sqrt(SemiPerimeter()*(SemiPerimeter() - _firstSide)*(SemiPerimeter() - _secondSide)
                                *(SemiPerimeter() - _thirdSide));
    }

    class Test
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите строны треугольника.");
            var sides = new string[3];
            try
            {
                sides = Console.ReadLine()?.Split(' ');
                var trigangle = new Triangle(Convert.ToDouble(sides?[0]), Convert.ToDouble(sides?[1]), Convert.ToDouble(sides?[2]));
                Console.WriteLine("\nПлощадь треугольника = {0}", trigangle.Area());
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nНеверный формат входных данных! Попробуйте заново.");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
        }
    }
}
