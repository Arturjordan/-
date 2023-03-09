using System;

namespace @struct
{
    struct TRAIN
    {
        public string Destination;
        public int Number;
        public DateTime Departure;
        public TRAIN(string destination, int number, DateTime departure)
        {
            Destination = destination;
            Number = number;
            Departure = departure;

        }

        public override string ToString()
        {
            return string.Format("Пункт назначения: {0}, № поезда: {1}, Отправление: {2}", Destination, Number, Departure);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TRAIN[] trains = new TRAIN[6];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введите название пункта назначения:  ");
                string destination = Console.ReadLine();

                Console.WriteLine("Введите номер поезда: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите дату отправления: ");
                DateTime departure = DateTime.Parse(Console.ReadLine());

                trains[i] = new TRAIN(destination, number, departure);
            }

            Console.WriteLine("Введите название пункта назначения для поиска или end для выхода");
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                bool trainFound = false;
                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].Destination == input)
                    {
                        Console.WriteLine(trains[i]);
                        trainFound = true;
                    }
                }

                if (!trainFound)
                    Console.WriteLine("Ничего не найдено. Повторите попытку");
            }
        }
    }
}