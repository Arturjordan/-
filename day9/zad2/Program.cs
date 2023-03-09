using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        public static void Main()
        {
            Employees andrey = Employees.Andrey;
            Employees vadim = Employees.Vadim;
            Employees dima = Employees.Dima;
            Employees artur = Employees.Artur;
            Employees lank = Employees.Lank;
            Employees vova = Employees.Vova;
            Employees kirill = Employees.Kirill;

            string[] employeersNames = { "andrey", "vadim", "dima", "artur", "lank", "vova", "kirill" };
            printAllEmployers(employeersNames);

            Console.WriteLine("Введите имя сотрудника о котором хотите узнать информацию(для выходы из программы напишите exit): ");
            string employeeChecker = Console.ReadLine();

            switch (employeeChecker)
            {
                case "andrey":
                    EmployeeInformation(andrey);
                    break;
                case "vadim":
                    EmployeeInformation(vadim);
                    break;
                case "dima":
                    EmployeeInformation(dima);
                    break;
                case "artur":
                    EmployeeInformation(artur);
                    break;
                case "lank":
                    EmployeeInformation(lank);
                    break;
                case "vova":
                    EmployeeInformation(vova);
                    break;
                case "kirill":
                    EmployeeInformation(kirill);
                    break;
                case "exit:":
                    break;
            }
        }

        enum Employees
        {
            Andrey = 10,
            Vadim = 20,
            Dima = 5,
            Artur = 15,
            Lank = 19,
            Vova = 30,
            Kirill = 44,
        }

        static void EmployeeInformation(Employees employees)
        {
            switch (employees)
            {
                case Employees.Andrey:
                    Console.WriteLine($"Сотруднику {Employees.Andrey} требуется отработать:{(int)Employees.Andrey} часов за месяц");
                    break;
                case Employees.Vadim:
                    Console.WriteLine($"Сотруднику {Employees.Vadim} требуется отработать:{(int)Employees.Vadim} часов за месяц");
                    break;
                case Employees.Dima:
                    Console.WriteLine($"Сотруднику {Employees.Dima} требуется отработать:{(int)Employees.Dima} часов за месяц");
                    break;
                case Employees.Artur:
                    Console.WriteLine($"Сотруднику {Employees.Artur} требуется отработать:{(int)Employees.Artur} часов за месяц");
                    break;
                case Employees.Lank:
                    Console.WriteLine($"Сотруднику {Employees.Lank} требуется отработать:{(int)Employees.Lank} часов за месяц");
                    break;
                case Employees.Vova:
                    Console.WriteLine($"Сотруднику {Employees.Vova} требуется отработать:{(int)Employees.Vova} часов за месяц");
                    break;
                case Employees.Kirill:
                    Console.WriteLine($"Сотруднику {Employees.Kirill} требуется отработать:{(int)Employees.Kirill} часов за месяц");
                    break;
            }
        }
        static void printAllEmployers(string[] arr)
        {
            Console.WriteLine("Все сотрудники:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + "." + arr[i]);
            }
        }
    }
}
