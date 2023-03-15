using System;
namespace Lib1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника:");
            Console.Write("   Сторона а: ");
            double aRectangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Сторона b: ");
            double bRectangle = Convert.ToDouble(Console.ReadLine());

            Rectangle Rectangle1 = new Rectangle(aRectangle, bRectangle);
            Console.WriteLine(Rectangle1.ToString());

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Введите стороны треугольника:");
            Console.Write("   Сторона а: ");
            double aTriangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Сторона b: ");
            double bTriangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Сторона c: ");
            double cTriangle = Convert.ToDouble(Console.ReadLine());

            Triangle Triangle1 = new Triangle(aTriangle, bTriangle, cTriangle);
            Console.WriteLine(Triangle1.ToString());
        }
    }
}