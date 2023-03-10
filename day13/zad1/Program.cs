using System;

namespace zad1
{
    class Program
    {
        public delegate double CalcFigure(double R);

        static double G_Lenght(double r)
        {
            double D;
            D = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности={0}", Math.Round(D, 3));
            return D;
        }
        static double G_Area(double r)
        {
            double S;
            S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь  круга={0}", Math.Round(S, 3));
            return S;
        }
        static double G_Volume(double r)
        {
            double V;
            V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine("Объем шара={0}", Math.Round(V, 3));
            return V;
        }
            public static void Zad1(CalcFigure a) 
            {
            Console.Write("Введите радиус = ");
            double rd = Convert.ToDouble(Console.ReadLine());
            a(rd);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус = ");
            double rad = Convert.ToDouble(Console.ReadLine());
            CalcFigure CF = new CalcFigure(G_Lenght);
            CF += G_Area;
            CF += G_Volume;

            CF(rad);

            Console.WriteLine("Выполнение");
            Zad1(CF);
            Console.ReadLine();
        }
    }
    
}

