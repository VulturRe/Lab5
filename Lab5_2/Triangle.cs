using System;

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

        public double Area() => SemiPerimeter()*(SemiPerimeter() - _firstSide)*(SemiPerimeter() - _secondSide)
                                *(SemiPerimeter() - _thirdSide);
    }
}
