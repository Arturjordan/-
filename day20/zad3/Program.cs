using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    /// <summary>
    /// Struct Parameters
    /// </summary>
    /// <param name="word"></param>
    /// <param name="page"></param>
    /// <returns>
    /// page, word value
    /// </returns>


    struct Params
    {
        public string word; //слово из указателя
        public int[] page; //массив с номерами страниц
        public Params(string word, int[] page) //конструктор с параметрами
        {
            this.word = word;
            this.page = page;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Params[] to = new Params[4];
            //ввод данных
            Console.Write("Введите количество слов, которое вы желаете ввести: ");
            string buf = Console.ReadLine();
            for (int i = 1; i <= Convert.ToInt32(buf); i++)
            {
                Console.Write("Введите слово в указатель: ");
                to[i].word = Console.ReadLine();

                Console.Write("Введите количество страниц для этого слова: ");
                string buf1 = Console.ReadLine();
                int buf11 = Convert.ToInt32(buf1);

                Console.Write("Введите номера страниц через запятую(,): ");
                string TempPage = Console.ReadLine();
                string[] TempPageMassive = TempPage.Split(',');
                int[] page = new int[] {
                    int.Parse(TempPageMassive[0].ToString()),
                    int.Parse(TempPageMassive[1].ToString()),
                    int.Parse(TempPageMassive[2].ToString()) };
                to[i].page = new int[buf11];
                to[i].page = page;

            }
            //вывод введеных с клавиатуры данных
            Console.WriteLine();
            for (int k = 1; k <= Convert.ToInt32(buf); ++k)
            {
                Console.WriteLine("{0}\t\t{1},{2},{3}", to[k].word, to[k].page[0], to[k].page[1], to[k].page[2]);
            }
            Console.ReadLine();
        }
    }
}
