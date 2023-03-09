using System;


namespace zadanie1._1
{
    class Demo
    {
        static void Main(string[] args)
        {
            //Задаем входящие параметры
            Master ob = new Master("Программист", "Петров", 4.5);
            //выполнение 
            Console.WriteLine(ob.Specialty + " " + ob.Name + " " + ob.Avg_rating);
            Console.WriteLine("Ваша стипендия");
            double stn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Насколько повысилась стипендия?");
            double stu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Увеличенная стипендия составила \n" + ob.UpGrant(ob.Grant(stn), stu));
            Console.ReadLine();
        }
    }
}
