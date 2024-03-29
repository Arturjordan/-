﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace zad3
{
    class Program
    {
        class Mnogochlen
        {
            private double[] A;//единственное поле класса(массив коэффициэнтов)
            
 
            public Mnogochlen (double[] VvodA)//конструктор класса, вызывается при создании нового элемента класса, для поддержки инкапсуляции, если она будет нужна
            {
                A=VvodA;                
            }
            
            public void VivodMnogochlena()
            {
                for (int i=0;i<A.Length-1;i++)
                    Console.Write("{0}x^{1} + ",A[i],A.Length-i-1);
                Console.Write(A[A.Length-1]+"\n");
            }
            public double ZnachenieMnogochlena(double x)/// возвращает значение многочлена в точке х
            {
                double rezalt=0;
                for (int i=0; i<A.Length; i++)
                {
                    double StepenX=1;
                    for(int j=0;j<A.Length-i-1;j++)
                        StepenX*=x;
                    rezalt+=StepenX*A[i];
                }
                return rezalt;            
            }
 
            public static Mnogochlen SlogitMnogochleni(Mnogochlen mn1, Mnogochlen mn2)
            {
                Mnogochlen mnRezalt = new Mnogochlen(new double [Math.Max(mn1.A.Length, mn2.A.Length)]); // создание массива, в который будет сложен результат. его размер будет соответсвовать большему из исходных.
                for(int i=mnRezalt.A.Length-1;i>=0;i--)
                {
                    if (i<mn1.A.Length)
                        mnRezalt.A[i]+=mn1.A[i];
                    if (i<mn2.A.Length)
                        mnRezalt.A[i]+=mn2.A[i];
                }
                return mnRezalt;
            }
 
            public static Mnogochlen UmnogitMnogochleni(Mnogochlen mn1, Mnogochlen mn2)
            {
                Mnogochlen mnRezult = new Mnogochlen (new double[mn1.A.Length+mn2.A.Length-1]);
                    for (int i1=0; i1<mn1.A.Length;i1++)
                    {
                        for (int i2=0; i2<mn2.A.Length;i2++)
                        mnRezult.A[i1+i2]+=mn1.A[i1]*mn2.A[i2];
                    }        
                return mnRezult;
            }
        }
        static void Main(string[] args)
        {
            Mnogochlen testMnogochlen1 = new Mnogochlen(new double[] {1,2,3,4,5}); //создание представителя класса с именем testMnogochlen и массивом таким-то.
            Mnogochlen testMnogochlen2 = new Mnogochlen(new double[] {1,1,1,1,1});
            testMnogochlen1.VivodMnogochlena();
            testMnogochlen2.VivodMnogochlena();
            Console.WriteLine("введите переменную для нахождения значения первого многочлена");
            double x= double.Parse(Console.ReadLine()); //ввод с клавиатуры переменной X;
            Console.WriteLine("значение многочлена в точке x= {0} будет {1}", x, testMnogochlen1.ZnachenieMnogochlena(x));
            Mnogochlen summa = Mnogochlen.SlogitMnogochleni(testMnogochlen1,testMnogochlen2);
            Mnogochlen proizvedenie = Mnogochlen.UmnogitMnogochleni(testMnogochlen1,testMnogochlen2);
            Console.WriteLine("сумма многочленов равна:");
            summa.VivodMnogochlena();
            Console.WriteLine("произведение моногочленов равно:");
            proizvedenie.VivodMnogochlena();
        }
    }
}