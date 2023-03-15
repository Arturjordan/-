using System;
namespace Lib1
{
    public class Triangle : Figure
    {
        private double _aItem;
        private double _bItem;
        private double _cItem;

        public double A { get => _aItem; }
        public double B { get => _bItem; }
        public double C { get => _cItem; }

        public TypeTriug Type { get; }

        public Triangle(double a, double b, double c)
        {
            if (CheckingForExistence(a, b, c))
            {
                _aItem = a;
                _bItem = b;
                _cItem = c;
                Type = DetermineType();
            }
            else
            {
                throw new Exception("Данный треугольник не может существовать.\n" +
                                    "Треугольник существует только тогда, когда сумма двух его сторон больше третьей.");
            }
        }

        public override double CountPerimeter() => _aItem + _bItem + _cItem;

        public override double CountSquare()
        {
            double p = CountPerimeter() / 2;
            return Math.Sqrt(p * (p - _aItem) * (p - _bItem) * (p - _cItem));
        }

        public override string ToString()
        {
            return $"Тип треугольника: \n" +
                   $"Стороны\n" +
                   $"  А:{_aItem}\n" +
                   $"  B:{_bItem}\n" +
                   $"  C:{_cItem}\n" +
                   $"Периметр: {CountPerimeter()}\n" +
                   $"Площадь: {CountSquare():.###}";
        }

        private bool CheckingForExistence(double aEx, double bEx, double cEx) => aEx + bEx > cEx && bEx + cEx > aEx && aEx + cEx > bEx;

        private TypeTriug DetermineType()
        {
            if (_aItem != _bItem && _aItem != _cItem && _bItem != _cItem)
            {
                return TypeTriug.Versatile;
            }
            else if (_aItem == _bItem && _aItem == _cItem && _bItem == _cItem)
            {
                return TypeTriug.Equilateral;
            }
            else
            {
                return TypeTriug.Isosceles;
            }
        }

    }
}