using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue();

            System.IO.StreamReader f = new System.IO.StreamReader(@"C:\Users\Admin\Desktop\3input.txt", Encoding.Default);
            string[] split = f.ReadToEnd().Split();
            Console.WriteLine("=== Исходный файл ===\n");
            foreach (string s in split)
            {
                Console.Write(s + " ");
                Q.Enqueue(s);
            }
            Console.WriteLine("\n\n=== Все слова, начинающиеся с прописной буквы ===\n");
            foreach (string str in Q)
            {
                if (str != "" && str != " ")
                {
                    if (str.Substring(0, 1).ToUpper() == str.Substring(0, 1))


                        if (!System.Text.RegularExpressions.Regex.IsMatch(str.Substring(0, 1), "^\\d{1}"))
                        {
                            Console.Write(str + " ");
                        }

                }
            }

            Console.WriteLine("\n\n=== Все слова, начинающиеся со строчной буквы ===\n");
            foreach (string str in Q)
            {
                if (str != "" && str != " ")
                {
                    if (str.Substring(0, 1).ToLower() == str.Substring(0, 1))


                        if (!System.Text.RegularExpressions.Regex.IsMatch(str.Substring(0, 1), "^\\d{1}"))
                        {
                            Console.Write(str + " ");
                        }

                }
            }
            Console.ReadLine();
        }
    }
}
