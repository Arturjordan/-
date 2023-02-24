using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product[] products = new Product[]
            {
                new MilkTovar("Cheese",5.15M,14),
                new Igrushka("Mishka",20M,"Sweet"),
                new Tovar("Soufa", 10000M)
            };

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            //Tovar arel = new Igrushka("Pony");
            //arel.Naz();
            Console.ReadLine();
        }


        class Igrushka:Tovar
        {
            public string Kind { get; set; }
            public Igrushka(string name,decimal cost, string kind):base(name,cost)
            {
               
                Kind = kind;
            }

            public override string ToString()
            {
                return $"Kind - {Kind} "; 
            }
            //public void naz()
            //{
            //    console.writeline($"игрушка - {name}");
            //


        }
        class Product 
        {
            public string Name { get; set; }
            
            //public int Cost { get; set; }
            //public int day = 14;
            //public string Nazvanie_e = "Tv";
            //public int Huge = 15;


            public Product(string name)
            {
                Name = name;
                //Cost = cost;
            }

            public override string ToString()
            {
                return $"Name - {Name} ";
            }
            //public void AboutProduct()
            //{
            //    Console.WriteLine($"Продукт: {Name}");
            //}
        }
        class Tovar:Product
        {
            public decimal Cost { get; set; }
            public Tovar(string name, decimal cost):base(name)
            {
                Cost = cost;
            }

            public override string ToString()
            {
                return base.ToString()+
                    $"Cost - {Cost} ";
            }
            //public void AboutTovar()
            //{
            //    base.AboutProduct();
            //    Console.WriteLine($"Cost - {Cost} ");
            //}
        }
        class MilkTovar : Tovar
        {
            public int Days { get; set; }

            public MilkTovar(string name, decimal cost, int days):base(name,cost)
            {

                Days = days;
            }
            public override string ToString()
            {
                return base.ToString()+
                    $"Days - {Days} "; 
            }
            //public void AboutMilkTovar()
            //{
            //    Console.WriteLine($"Название молочного товара: {Nazvanie}, Срок годности в течении {day} дней ");
            //}
        } 
    }
}
