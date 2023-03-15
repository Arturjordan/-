namespace Lib1
{
    public class Rectangle : Figure
    {
        private double _aItem;
        private double _bItem;

        public double A
        {
            get => _aItem;
        }

        public double B
        {
            get => _bItem;
        }

        public Rectangle(double a, double b)
        {
            _aItem = a;
            _bItem = b;
        }

        public override double CountPerimeter() => _aItem * 2 + _bItem * 2;

        public override double CountSquare() => _aItem * _bItem;

        public override string ToString()
        {
            return $"Стороны:\n" +
                   $"  A:{_aItem}\n" +
                   $"  B:{_bItem}\n" +
                   $"Периметр: {CountPerimeter()}\n" +
                   $"Площадь: {CountSquare():.###}";
        }
    }
}