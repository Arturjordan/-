using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
internal class Program
{
public static double Fact(int x)
{
double factorial = 1;
while (x > 1)
{
factorial *= x;
x--;
}
return factorial;
}
static void Main(string[] args)
{
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
double ans = Fact(n + 2) / Fact(n + 4);
Console.WriteLine($"f({n}) = {ans}");
Console.ReadLine();
}
}
}

